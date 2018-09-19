package util;

import http.HttpRequest;
import http.HttpResponse;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStream;
import java.io.InputStreamReader;

public class RequestParser {

    private HttpRequest request;

    public RequestParser() {
        this.request = new HttpRequest();
    }

    public HttpRequest makeRequest(InputStream request) throws IOException {

        BufferedReader reader = new BufferedReader(new InputStreamReader(request));

        String line = reader.readLine();

        defineMethodPathAndHttpVersionForRequest(line);

        while (line != null && !line.isEmpty()) {

            System.out.println(line);

            line = reader.readLine();

            if (line != null && !line.isEmpty() ) {
                defineHeaders(line);
            }
        }

        return this.request;
    }

    private void defineHeaders(String line) {

        String[] header = line.split(": ");

        String key = header[0];
        String value = header[1];
        this.request.addHeaders(key, value);
    }

    private void defineMethodPathAndHttpVersionForRequest(String line) {

        if (line != null) {
            String[] firstLine = line.split(" ");
            this.request.setHttpMethod(firstLine[0]);
            this.request.setPath(firstLine[1]);
            this.request.setHttpVersion(firstLine[2]);
        }
    }
}
