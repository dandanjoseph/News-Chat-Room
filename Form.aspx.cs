using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//This is a simple .net webpage that will be discussed in more detail in the papers that you can find in the repository
//We will be talking about the differences from this language and java as well as the idea of threads and processes when working with .net
//This webpage is ment to have users send messages back and forth to eachother like a chat room
//after the 10th message they begin to delete
//Author: Joseph Dandan
//CSCI 370



public partial class Form : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        //On page load we clear our items in the box
        this.ListBox1.Items.Clear();
    }

    //this is our send button
    protected void Button2_Click(object sender, EventArgs e)
    {
        //we attach the message and who its from 
        string temp = TextBox1.Text + TextBox2.Text;
        //our messages are stored locally on a file since we do not have a server to keep this data on
        const string Path = @"C:\Users\Dan the man\Desktop\news.txt";
        //this helps with out with setting up the path to where the data is stored
        FileInfo newsstuff = new FileInfo(Path);
        //the following code helps us take the data and put it in our text file to save it 
        using (TextWriter textwritter = newsstuff.AppendText())
        {

            textwritter.WriteLine(temp);
            textwritter.Flush();
            textwritter.Close();
            
              
        
        }


    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

        



    }

    //this is our receive button they press this to update there news
    protected void Button1_Click(object sender, EventArgs e)
    {
        //this is where they are getting there news
        const string Path = @"C:\Users\Dan the man\Desktop\news.txt";

        //this is to id the path
        FileInfo newsstuff = new FileInfo(Path);
        //we use the following to get the data from the file
        using (StreamReader sRead = newsstuff.OpenText()) {
            //we have a loop that continues untill there is no more data
            while (!sRead.EndOfStream)
            {
                    //we add the items to the listbox for each line in the file
                    ListBox1.Items.Add(sRead.ReadLine());
                    //we want to only display ten so we delete once we are past that amount
                    if (this.ListBox1.Items.Count == 10)
                    {
                        this.ListBox1.Items.RemoveAt(1);
                    
                    }

            }
            //this closes everything
            sRead.Close();
        }

    }
}