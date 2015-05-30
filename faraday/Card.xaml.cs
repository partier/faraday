using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.IO;
using System.Text;
using faraday.Data_Types;

namespace faraday
{
    public partial class Card : PhoneApplicationPage
    {
        private CardJSON card = null;

        public Card()
        {
            InitializeComponent();
        }

        public void Initialize(String json)
        {
            card = new CardJSON(json);
        }

        public void Initialize(CardJSON card)
        {
            this.card = card;
        }

        public override string ToString()
        {
            if (card == null)
                return "";

            return "\nTitle:  " + card.Title +
                   "\nBODY:  " + card.Body +
                   "\nHELP:  " + card.Help +
                   "\nTYPE:  " + card.Type +
                   "\nID:  <" + card.ID + ">";
        }
    }
}