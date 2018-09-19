package http;

import java.util.Arrays;
import java.util.Map;

public class HttpResponse {

    private String protocol;
    private int responseCode;
    private String body;
    private String responseCodeMessage;
    private Map<String, String> headers;

    public HttpResponse() {
    }

    public String getProtocol() {
        return protocol;
    }

    public void setProtocol(String protocol) {
        this.protocol = protocol;
    }

    public int getResponseCode() {
        return responseCode;
    }

    public void setResponseCode(int responseCode) {
        this.responseCode = responseCode;
    }

    public String getBody() {
        return body;
    }

    public void setBody(String body) {
        this.body = body;
    }

    public Map<String, String> getHeaders() {
        return headers;
    }

    public void setHeaders(Map<String, String> headers) {
        this.headers = headers;
    }

    public String getResponseCodeMessage() {
        return responseCodeMessage;
    }

    public void setResponseCodeMessage(String responseCodeMessage) {
        this.responseCodeMessage = responseCodeMessage;
    }

    public byte[] getResponseBytes(){
        return makeResponseString().getBytes();
    }

    private String makeResponseString() {
        return protocol + " " + responseCode + " " + responseCodeMessage + '\n'
        + "\n"
        + body;
    }

    @Override
    public String toString() {
        return "HttpResponse{" +
                "protocol='" + protocol + '\'' +
                ", responseCode=" + responseCode +
                ", body='" + body + '\'' +
                ", responseCodeMessage='" + responseCodeMessage + '\'' +
                ", headers=" + headers +
                '}';
    }

    /*    private String mockResponse() {

        return "HTTP/1.0 200 Ok\n" +
                "\n" +
                "<!DOCTYPE www.html>\n" +
                "<www.html lang=\"en\">\n" +
                "<head>\n" +
                "    <meta charset=\"UTF-8\">\n" +
                "    <title>Início</title>\n" +
                "</head>\n" +
                "<body>\n" +
                "    <h2>Seja bem vindo jovem!</h2>\n" +
                "</body>\n" +
                "</www.html>";
    }*/
}
