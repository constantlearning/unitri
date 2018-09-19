package util;

import http.HttpRequest;
import http.HttpResponse;

import java.io.InputStream;
import java.io.OutputStream;
import java.net.Socket;
import java.util.concurrent.TimeUnit;

public class ThreadConnection implements Runnable {

    private Socket client;

    public ThreadConnection(Socket client) {
        this.client = client;
    }

    @Override
    public void run() {

        try {

            System.out.println("Received request! \n\n");

            InputStream inputStream = this.client.getInputStream();

            RequestParser requestBuilder = new RequestParser();

            HttpRequest httpRequest = requestBuilder.makeRequest(inputStream);

            RequestInterpreter requestInterpreter = new RequestInterpreter();

            HttpResponse response = requestInterpreter.processRequest(httpRequest);

            OutputStream outputStream = this.client.getOutputStream();

            System.out.println(response);

            outputStream.write(response.getResponseBytes());

//            System.out.println("Waiting 2 Seconds...");
//            TimeUnit.SECONDS.sleep(2);
            System.out.println("\n\nDone.");

            outputStream.flush();

            outputStream.close();
        } catch (Exception e) {
            e.printStackTrace();
            throw new RuntimeException(e);
        }
    }
}
