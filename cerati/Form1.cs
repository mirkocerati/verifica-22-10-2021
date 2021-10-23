using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cerati
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void booknow_Click(object sender, EventArgs e)
        {
            Reservation reservation = new Reservation();

            // Controllo nome e salvo
            if (name.TextLength > 3)
                reservation.Name = name.Text;
            else
            {
                error("Inserisci un nome valido.");
                return;
            }


            // Controllo città e salvo
            if (city.TextLength > 3)
                reservation.City = city.Text;
            else
            {
                error("Inserisci una città valida.");
                return;
            }

            // Controllo data < 15 e salvo
            if ((checkout.Value - checkin.Value).Days <= 15)
            {
                reservation.CheckInDate = checkin.Value;
                reservation.CheckOutDate = checkout.Value;
            }
            else
            {
                error("La durata del viaggio non può superare i 15 giorni.");
                return;
            }


            // Controllo ospiti < 4 e salvo
            if (adults.SelectedIndex > -1 && children.SelectedIndex > -1)
            {
                if(int.Parse(adults.SelectedItem.ToString()) + int.Parse(children.SelectedItem.ToString()) <= 4)
                {
                    reservation.Adults = int.Parse(adults.SelectedItem.ToString());
                    reservation.Children = int.Parse(children.SelectedItem.ToString());
                } else
                {
                    error("Il numero di ospiti non può essere maggiore di 4.");
                    return;
                }
            }
            else
            {
                error("Inserisci il numero di ospiti. (max 4)");
                return;
            }

            
            //Controllo stanza e salvo
            if (roomtype.Controls.OfType<RadioButton>().Any(x => x.Checked))
                reservation.RoomType = roomtype.Controls.OfType<RadioButton>().First(r => r.Checked).Text.ToUpper();
            else
            {
                error("Seleziona un tipo di stanza.");
                return;
            }


            //Controllo lenzuola e salvo
            if (sheet.SelectedIndex > -1)
                reservation.SheetSet = sheet.SelectedItem.ToString().ToUpper();
            else
            {
                error("Seleziona il colore delle lenzuola.");
            };

            //Salvo gli optional inseriti e temp
            reservation.CleanTowelsDaily = opttowel.Checked;
            reservation.OledTv = opttv.Checked;

            reservation.Temp = int.Parse(temptxt.Text);

            // Conferma prenotazione nella text box
            confirmation.Text = reservation.ConfirmationText();


        }

        //Invia un msg di errore
        private void error(string message)
        {
            MessageBox.Show(message, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void tempup_Click(object sender, EventArgs e)
        {
            temptxt.Text = (int.Parse(temptxt.Text) + 1).ToString();
        }

        private void tempdown_Click(object sender, EventArgs e)
        {
            temptxt.Text = (int.Parse(temptxt.Text) - 1).ToString();
        }

        private void sheet_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = ".\\images\\" + sheet.SelectedItem.ToString().ToLower() + ".jpg";
        }
    }
}
