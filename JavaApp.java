import java.util.Scanner;

public class JavaApp {

    public static void main(String[] args) {
     // Get the user input (aesthetic values color or shape)
     Scanner scanner = new Scanner(System.in);

     System.out.println("Enter a color name (e.g., 'red','blue'): ");
     String colour = scanner.nextLine();

     System.out.println("Enter a shape (e.g., 'circle', 'square'):");
     String shape = scanner.nextLine();

     // Perform aesthetic processing(here , we'll just mock a simple transformation)
     String transformedColour = transformColour(colour);
     String transformedShape = transformShape(shape);  
     
     //Outputting the results to be captured by C# 
     System.out.println("Processed Colour: " + transformedColour);
     System.out.println("Processed Shape: " + transformedShape);


     scanner.close();

    }
// Mock aesthetic transformations
private static String transformColour(String colour) {
 switch (colour.toLowerCase()){
  case "red": return "Crimson Red";
  case "blue": return "Sky Blue";
  default: return "Colour not recognised";
 } 
}

private static String transformShape(String shape){
 if ("circle".equalsIgnoreCase(shape)) {
      return "Rounded Circle";
  } else if ("square".equalsIgnoreCase(shape)){
     return "Perfect Square";
  }
   return "Shape not recognised";
}

}