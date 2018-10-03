package util;

import http.HttpRequest;
import http.HttpResponse;
import http.HttpStatus;

import java.io.*;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.util.*;

public class RequestInterpreter {

    private HttpResponse httpResponse;

    private final String basePath = "/home/lrodrigues/Documents/lucas/unitri/unitri/unitri-ppi/servidor-http-multi-thread/src/www/";

    private int statusCode;

    private String content = "";

    public RequestInterpreter() {
        this.httpResponse = new HttpResponse();
    }

    public HttpResponse processRequest(HttpRequest httpRequest) throws IOException, InterruptedException {

        String path = findPath(httpRequest.getPath());

        if (path.contains("cgi")) {
            runCgiProgram(path);
        } else {

            try {
                content = getFileContent(path);
                statusCode = 200;
            } catch (IOException e) {
                this.notFound();
            }
        }

        this.httpResponse.setBody(content);
        this.httpResponse.setResponseCode(statusCode);
        this.httpResponse.setResponseCodeMessage(HttpStatus.valueOf(statusCode));
        this.httpResponse.setProtocol("HTTP/1.0");

        return this.httpResponse;
    }

    private String findPath(String path) {

        String fullPath = "";

        if (path.equals("/")) {
            fullPath = this.basePath + "html/index.html";
        }

        if (path.contains(".html")) {
            fullPath = this.basePath + "html" + path;
        }

        if(path.contains(".css")){
            fullPath = this.basePath + "css" + path;
        }

        if (path.contains("cgi/")) {
            fullPath = this.basePath + path.replace("/cgi/", "cgi/");
        }

        return fullPath;
    }

    private void notFound() {
        try {
            content = getFileContent(this.basePath + "html/404.html");
            statusCode = 404;
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    private void runCgiProgram(String cgi) {

        try {

            String queryString = getQueryString(cgi);

            String path = getCgiPath(cgi);

            String[] enviromentVariable = { "QUERY_STRING=" + queryString };

            String command = "python3.6 " + path;

            Process process = Runtime.getRuntime().exec(command, enviromentVariable);

            InputStream inputStream = process.getInputStream();

            BufferedReader reader = new BufferedReader(new InputStreamReader(inputStream));

            String line = reader.readLine();
            StringBuilder sb = new StringBuilder();
            while (line != null) {
                sb.append(line);
                line = reader.readLine();
            }

            this.content = sb.toString();

            this.statusCode = 200;

            inputStream.close();

        } catch (Exception e) {
            this.notFound();
            e.printStackTrace();
        }
    }

    private String getCgiPath(String cgi) {

        if (cgi.contains("?")) {
            int index = cgi.indexOf("?");
            return cgi.substring(0, index);
        }
        return cgi;
    }

    private String getQueryString(String path) {

        int index = path.indexOf("?");

        if (index == -1) {
            throw new RuntimeException("Doens't cgi program!");
        }

        String argumentsFromPath = path.substring(index);
        return argumentsFromPath.replace("?", "");
    }

    private String getFileContent(String path) throws IOException {
        List<String> fileContent = new ArrayList<>(Files.readAllLines(Paths.get(path)));
        return String.join("", fileContent);
    }

}
