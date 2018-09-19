package http;

import java.util.HashMap;
import java.util.Map;

public class HttpRequest {

    private String httpMethod;
    private String path;
    private String httpVersion;
    private Map<String, String> headers;
    private String Body;

    public HttpRequest() {
        headers = new HashMap<>();
    }

    public String getHttpMethod() {
        return httpMethod;
    }

    public void setHttpMethod(String httpMethod) {
        this.httpMethod = httpMethod;
    }

    public String getPath() {
        return path;
    }

    public void setPath(String path) {
        this.path = path;
    }

    public String getHttpVersion() {
        return httpVersion;
    }

    public void setHttpVersion(String httpVersion) {
        this.httpVersion = httpVersion;
    }

    public Map<String, String> getHeaders() {
        return headers;
    }

    public void setHeaders(Map<String, String> headers) {
        this.headers = headers;
    }

    public String getBody() {
        return Body;
    }

    public void setBody(String body) {
        Body = body;
    }

    public void addHeaders(String key, String value) {
        this.headers.put(key, value);
    }
}
