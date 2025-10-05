using System;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

public partial class Form1 : Form{
   private string colour;
   private string shape;
   private string javaOutput;

   public Form1(){
     InitialiseComponent();
    this.text = "Aesthetic App";
    this.ClientSize = new size(600,400);
   }
 
 // Button used for collecting user input and display the virtual objects
 private void btnGenerate_Click(object sender, EventArgs e){
  colour = txtColour.Text;
  shape  = txtShape.Text;

  // Call Java to process the input and get the output
  javaOutput = CallJavaProgram(colour,shape); 

  // Refresh the canvas to display the virtual objects
  this.Invalidate();
 }

// Method to call the java program
private string CallJavaProgram(string colour,string shape){
 try{
   ProcessStartInfo startInfo = new ProcessStartInfo {
    


   }

 }

}




}