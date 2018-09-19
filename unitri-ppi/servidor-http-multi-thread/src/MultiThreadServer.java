import util.ThreadConnection;

import java.io.IOException;
import java.net.ServerSocket;
import java.net.Socket;

public class MultiThreadServer {

    private static int PORTA = 8000;

    public static void main(String[] args) throws IOException {

        ServerSocket serverSocket = new ServerSocket(PORTA);

        Socket socket;

        System.out.println("Server started and listen on port " + PORTA + ".");

        while (true) {

            socket = serverSocket.accept();

            if (socket.isConnected()) {

                ThreadConnection connection = new ThreadConnection(socket);

                Thread t = new Thread(connection);
                t.start();
            }
        }

    }
}
