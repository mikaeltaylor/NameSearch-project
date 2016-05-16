using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
/*Program: NameSearch
 * Developer: Mikael Taylor
 * Date: 3/11/2016
 * Description: Parses the contents of BoyNames.txt & GirlNames.txt into a list,
 *              and searches for the user entry within the list. Asks for entry if
 *              the user has not entered a name and hits the submit button. 
 * 
 */
namespace NameSearch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Intitialize the form.
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {//On clicking the search button..
            string fileName;//fileName variable
            string fileName2;//second filename variable
            string searchName;//search name variable from user input
            string searchName2;//second search name variable from user input
            string nameType;//type of name(boy/girl)
            try//try to..
            {
                if (txtBoysInput.Text != "" || txtGirlsInput.Text != "")
                    //If either of the textboxes are not empty..
                {
                    if (txtBoysInput.Text != null && txtGirlsInput.Text == "")
                    {
                        //if the boys text box is not empty
                        fileName = "BoyNames.txt";
                        nameType = "boy's";
                        //set the file name, and the name type to reflect the masculine gender
                        searchName = txtBoysInput.Text;
                        //set the search name variable to the boy's contents.
                        parseSearchSingleFile(fileName, searchName, nameType);
                        //Parse the file into a list, and search it.
                    }
                    else if (txtGirlsInput.Text != null && txtBoysInput.Text == "")
                    {//if the girls textbox is not empty and the boys is empty..
                        fileName = "GirlNames.txt";
                        nameType = "girl's";
                        //set the file name, and the name type to reflect the feminine gender
                        searchName = txtGirlsInput.Text;
                        //set the search name to the user's input
                        parseSearchSingleFile(fileName, searchName, nameType);
                        //parse the file into a list, and search the list.
                    }
                    else if (txtGirlsInput.Text != null && txtBoysInput.Text != null)
                    {
                        fileName = "GirlNames.txt";
                        searchName = txtBoysInput.Text;
                        fileName2 = "BoyNames.txt";
                        searchName2 = txtGirlsInput.Text;
                        //set the file names, and collect the user input for the search names.
                        parseSearchBothFiles(fileName, fileName2, searchName, searchName2);
                        //parse the files, and search both of them.
                    }
                }
                else
                {
                    MessageBox.Show("Enter a name, please.");
                    //Show the messagebox for empty textboxes.  AKA prompt for user entry.
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Code: " + ex);
                //if something goes wrong, show the error code, please.
            }

    }
        private void parseSearchSingleFile(string fileName, string searchName, string nameType)
        {
            List<string> names = new List<string>();
            //create a list array of names
            using (var reader = new StreamReader(fileName))
            {
                while (reader.Peek() >= 0)
                    //if there's more than 0 lines left..
                    names.Add(reader.ReadLine());
                //add the line to the list.
            }
            if (searchName != "")
            {//if the searchname is not empty
                if (names.Contains(searchName))
                {//and the list contains the search name..
                    MessageBox.Show("The name " + searchName + "is among the most popular " + nameType + " names!");
                }//Tell us about it.
                else
                {//otherwise..
                    MessageBox.Show("The name was not among the most popular " + nameType + " names.");
                }//Tell us it isn't in the list.
            }
            else
            {
                MessageBox.Show("Enter a name, please.");
            }//if it is empty, prompt for user entry. 
        }
        private void parseSearchBothFiles(string fileName, string fileName2, string searchName, string searchName2)
        {
            List<string> girlsNames = new List<string>();
            //create a girls name list
            using (var girlsReader = new StreamReader(fileName))
            {
                while (girlsReader.Peek() >= 0)//If there's more than 0 valid lines
                girlsNames.Add(girlsReader.ReadLine());//add the line to the list
            }
            if (searchName != "" && searchName2 != "")
            {//if both search names aren't empty..
                List<string> boysNames = new List<string>();
                //create a list of boy's names
                using (var boysReader = new StreamReader(fileName2))
                {
                    while (boysReader.Peek() >= 0)//while there are more than 0 lines left
                        boysNames.Add(boysReader.ReadLine());
                }
                if (girlsNames.Contains(searchName2) && boysNames.Contains(searchName))
                {//if both names are on the list
                    MessageBox.Show("The name " + searchName2 + " was among the most popular girl's names, and the name " + searchName + "was among the most popular boy's names!");
                }//tell us about it
                else if (boysNames.Contains(searchName))
                {//if just the boy's name is on the list
                    MessageBox.Show("The name " + searchName + "was among the most popular boy's names!");
                }//tell us about it
                else if (girlsNames.Contains(searchName2))
                {//if just the girls name is on the list
                    MessageBox.Show("The name " + searchName2 + " was among the most popular girl's names!");
                }//tell us about it
                else
                {
                    MessageBox.Show("The name was not amongst the most popular names.");
                }//If not, let us know as well.
            }
            else
            {//if the search names were empty..
                MessageBox.Show("Enter a name, please.");
            }//Prompt for valid user input.
        }
    }
}
