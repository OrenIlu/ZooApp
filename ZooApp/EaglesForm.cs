using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooApp
{
    public partial class EaglesForm : Form
    {
        private List<Eagle> listOfLoins;
        public EaglesForm()
        {
            InitializeComponent();
            listOfLoins = LoadBird();
            listBox1.DataSource = listOfLoins;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                if (numericAge.Value == 0 || comboxDiet.SelectedIndex == -1 || txbxName.Text == "" || comboxSpecies.SelectedIndex == -1)
                {
                    throw new ArgumentNullException();
                }
                Eagle newEagle = new Eagle()
                {
                    Age = (int)numericAge.Value,
                    Name = txbxName.Text,

                    CanFly = chkCanFly.Checked ? true : false,
                    Milage = chkCanFly.Checked ? new Random().Next(1, 2000) : 0,
                    Diet = comboxDiet.SelectedItem.ToString(),

                    Wingspan = (int)numericWingspan.Value,
                    Species =comboxSpecies.SelectedItem.ToString(),
                };

                listOfLoins.Add(newEagle);
                SaveEagles(listOfLoins);
                listBox1.DataSource = null;
                listBox1.DataSource = listOfLoins;
                MessageBox.Show("Eagle is Added to the Zoo", "Eagle Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("Eagle Not Added!\nError: One or more values are missing", "Missing Value Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Eagle Not Added!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                try
                {
                    if (numericAge.Value == 0 || comboxDiet.SelectedIndex == -1 || txbxName.Text == "" || comboxSpecies.SelectedIndex == -1)
                    {
                        throw new ArgumentException("Eagle Not Updated!\nError: One or more values are missing");
                    }
                    // Get the selected Tiger
                    var selectedBird = listBox1.SelectedItem as Eagle;

                    // Update the Tigers's properties
                    selectedBird.Age = (int)numericAge.Value;
                    selectedBird.Name = txbxName.Text;
                    selectedBird.CanFly = chkCanFly.Checked ? true : false;
                    if (chkCanFly.Checked && selectedBird.Milage == 0)
                    {
                        selectedBird.Milage = new Random().Next(1, 2000);
                    }
                    else if (chkCanFly.Checked == false && selectedBird.Milage != 0)
                    {
                        selectedBird.Milage = 0;
                    }
                    selectedBird.Diet = comboxDiet.SelectedItem.ToString();
                    selectedBird.Wingspan = (int)numericWingspan.Value;
                    selectedBird.Species = comboxSpecies.SelectedItem.ToString();


                    // Refresh the ListBox to reflect the changes
                    listBox1.DataSource = null;
                    listBox1.DataSource = listOfLoins;
                    SaveEagles(listOfLoins);

                    MessageBox.Show("Eagle is Updated to the Zoo", "Eagle Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex.Message}", "Eagle Not Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Select Eagle To Update", "Eagle Not Updated", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                // Get the selected Fish
                var selectedBird = listBox1.SelectedItem as Eagle;

                // Remove the Fish from the list
                listOfLoins.Remove(selectedBird);

                SaveEagles(listOfLoins);
                listBox1.DataSource = null;
                // Refresh the ListBox to reflect the changes
                listBox1.DataSource = listOfLoins;
                btnClear_Click(sender, e);
                MessageBox.Show("Eagle is Removed in the Zoo.", "Eagle Removed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Select Eagle To Delete", "Eagle Not Removed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                var selectedAnimal = (Eagle)listBox1.SelectedItem;

                // Perform actions based on the selected Eagle
                numericAge.Value = selectedAnimal.Age;
                txbxName.Text = selectedAnimal.Name;
                chkCanFly.Checked = selectedAnimal.CanFly;
                comboxDiet.SelectedItem = selectedAnimal.Diet;
                numericWingspan.Value = selectedAnimal.Wingspan;
                comboxSpecies.SelectedItem = selectedAnimal.Species;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
            numericAge.Value = 0;
            txbxName.Text = "";
            chkCanFly.Checked = false;
            comboxDiet.SelectedIndex = -1;
            numericWingspan.Value = 0;
            comboxSpecies.SelectedIndex = -1;
        }
        private List<Eagle> LoadBird()
        {
            List<Eagle> Bird;

            using (FileStream fileStream = new FileStream("Eagles.bin", FileMode.Open))
            {
                DataContractSerializer serializer = new DataContractSerializer(typeof(List<Eagle>));
                Bird = (List<Eagle>)serializer.ReadObject(fileStream);
            }

            return Bird;
        }
        private void SaveEagles(List<Eagle> listOfLoins)
        {
            using (FileStream fileStream = new FileStream("Eagles.bin", FileMode.Create))
            {
                DataContractSerializer serializer = new DataContractSerializer(typeof(List<Eagle>));
                serializer.WriteObject(fileStream, listOfLoins);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                try
                {
                    var selectedAnimal = listBox1.SelectedItem as Eagle;
                    string pictureName = selectedAnimal.ShowPicture();

                    // Check if the picture name is valid
                    if (!string.IsNullOrEmpty(pictureName))
                    {
                        // Construct the path to the picture based on the picture name
                        var picture = (Image)Properties.Resources.ResourceManager.GetObject(pictureName);

                        if (picture != null)
                        {
                            // Display the picture in a popup window
                            using (Form pictureForm = new Form())
                            {
                                PictureBox pictureBox = new PictureBox();
                                pictureBox.Image = picture;
                                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                                pictureBox.Dock = DockStyle.Fill;

                                pictureForm.Controls.Add(pictureBox);
                                pictureForm.StartPosition = FormStartPosition.CenterScreen;
                                pictureForm.ShowDialog();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Picture not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid picture name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Error: No Eagle was Selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnSound_Click(object sender, EventArgs e)
        {
            SoundPlayer audio = new SoundPlayer(ZooApp.Properties.Resources.Eagle_Sound);
            audio.Play();
        }
    }
}