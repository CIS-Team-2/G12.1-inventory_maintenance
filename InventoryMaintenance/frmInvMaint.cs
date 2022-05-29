using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/***************************************************************************************************
* CIS 123: Introduction to OOP     |                                                               *
* Murach's C#, 7th Edition         |    Exercise 12-1    Create and use a class                    *
* Chapter 12 Extra Exercises       |    Add a class to an Inventory Maintenance application and    *
* Team 2 Assignment, 28MAY2022     |    then add code to the two forms that use this class.        *
* Patrick McKee & Dominique Tepper |                                                               *
***************************************************************************************************/

namespace InventoryMaintenance
{
    public partial class frmInvMaint : Form
    {
        public frmInvMaint()
        {
            InitializeComponent();
        }
/* ******************************************************************************************
*   6. Declare a class-level List<InvItem> variable named invItems with an initial
*      value of null
*      
*   Patrick McKee & Dominique Tepper, 28MAY2022
* ******************************************************************************************/

        private List<InvItem> invItems = null;

        /*private void HandleChange(InvItemList list)
        {
        //    invItems.Save();
           FillItemListBox();
        }*/

        private void frmInvMaint_Load(object sender, EventArgs e)
        {
            // Add a statement here that gets the list of items.
            invItems = InvItemDB.GetItems();
            FillItemListBox();
        }

        private void FillItemListBox()
        {
            InvItem item;
            lstItems.Items.Clear();
            
            // Add code here that loads the list box with the items in the list.
            for (int i = 0; i < invItems.Count; i++)
            {
                item = invItems[i];
                lstItems.Items.Add(item.GetDisplayText("\t"));
            }
            
            
            
            //foreach (InvItem i in invItems)
            //{
            //    lstItems.Items.Add(i.GetDisplayText("\t"));
           //}
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Add code here that creates an instance of the New Item form
            // and then gets a new item from that form.

            frmNewItem newItemForm = new frmNewItem();
            InvItem invItem = newItemForm.GetNewItem();
            if (invItem != null)
            {
                invItems.Add(invItem);
                FillItemListBox();
            }

            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstItems.SelectedIndex;
            if (i != -1)
            {
                // Add code here that displays a dialog box to confirm
                // the deletion and then removes the item from the list,
                // saves the list of products, and refreshes the list box
                // if the deletion is confirmed.

                InvItem invItem = invItems[i];
                string message = "Are you sure you want to delete " +
                    invItem.Description + "?";
                DialogResult button = MessageBox.Show(message, "Confirm Delete",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (button == DialogResult.Yes)
                {
                    invItems.Remove(invItem);
                    FillItemListBox();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }

    }
}
