import javafx.application.Application;
import javafx.scene.Scene;
import javafx.scene.layout.StackPane;
import javafx.scene.paint.Color;
import javafx.scene.shape.Circle;
import javafx.scene.shape.Rectangle;
import javafx.stage.Stage;

public class AestheticApp extends Application {

    public static void main(String[] args) {
        launch(args);
    }

    @Override
    public void start(Stage primaryStage) {
        // User input
        String colour = "red";
        String shape = "circle";

        // Craete the root pane
        StackPane root = new StackPane();

        // Display based on shape
        if ("circle".equalsIgnoreCase(shape)) {
            Circle circle = new Circle(100, Color.RED);
            root.getChildren().add(circle);
        } else if ("square".equalsIgnoreCase(shape)) {
            Rectangle square = new Rectangle(100, 100, Color.RED);
            root.getChildren().add(square);
        }

        // Setting the scene
        Scene scene = new Scene(root, 300, 250);
        primaryStage.setTitle("Aesthetic App");
        primaryStage.setScene(scene);
        primaryStage.show();
    }

}