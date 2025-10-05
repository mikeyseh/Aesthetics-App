using System;
using System.Diagnostics;

class Program{
  static void Main(){
    Console.WriteLine("Welcome to the Aesthetic Application!");

    //Collect user input
    Console.Write("Enter a colour name (e.ghh., 'red', 'blue'): ");
    string colour = Console.ReadLine();

    Console.Write("Enter a colour name (e.ghh., 'red', 'blue'): ");
    string shape = Console.ReadLine();

   // Call the Java program and pass the input to it
   string result = CallJavaProgram(colour,shape);

   // Display the results from java
   Console.WriteLine("\nProcessed Output from Java Program:");
   Console.WriteLine(result);
  }

// Method to run Java program and capture its output
 static string CallJavaProgram(string color,string shape){
   try{
       
       // Start the Java process
       ProcessStarInfo startInfo = new ProcessStarInfo {
         FileName = "java" ,
         Arguements = $" -cp . JavaApp {shape}",
         RedirectStandardOutput = true,
         UseShellExecute = false,
         CreateNoWindow = true,
   };

    Process process = process.Start(startInfo);
    string output = process.StandardOutput.ReadToEnd();

    process.WaitForExit();

    return output;

   }
catch (Exception ex){
  return $"Error: {ex.message}";
}  

 }
 
}

// Overriding OnPaint to render shapes or colors on the form
protected override void OnPaint(PaintEventArgs e)
{
   base.OnPaint(e);

   if (!string.IsNullOrEmpty(javaOutput)){
      Graphics g = e.Graphics;
      // Parse the result from java to display the objects 
   if(javaOutput.Contains("Processed Color"))
   {
      // Display color as a filled rectangle
      g.FillRectangle(new SolidBrush(Color.FromName(colour)),50,50,200,100);

   }
    if(javaOutput.Contains("Processed Shape"))
   {
      // Display as a shape based on output
      if(javaOutput.Contains("Circle"))
   {
      // Display color as a filled rectangle
      g.FillRectangle(new SolidBrush(Color.FromName(colour)),100,200,100,100); // Circle
       
   }
   else if (javaOutput.Contains("Square"))
   {
      g.FillRectangle(new SolidBrush(Color.FromName(colour)),100,200,100,100); // Square
       
      }    
   }
}

}

//UI Elements