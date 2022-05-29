using System;
using System.Collections.Generic;
using System.Text;

/***************************************************************************************************
* CIS 123: Introduction to OOP     |                                                               *
* Murach's C#, 7th Edition         |    Exercise 12-1    Create and use a class                    *
* Chapter 12 Extra Exercises       |    Add a class to an Inventory Maintenance application and    *
* Team 2 Assignment, 28MAY2022     |    then add code to the two forms that use this class.        *
* Patrick McKee & Dominique Tepper |                                                               *
***************************************************************************************************/

/* *******************************************************************************************
* 2. Add a class named InvItem to the project and add:
* 
*       a. Properties
*           i. ItemNo           int
*          ii. Description      string
*         iii. Price            decimal
*
*       b. Method           GetDisplayText() 
*          Returns a string that contains itemNo, description, and price
*          Item number and description are separated by 4 spaces
*          
*       c. Constructor
*           i. ()
*               Creates an InvItem object with default values
*           ii.(itemNo, description, price)
*               Creates an InvItem object with the specified values
*               
*  Patrick McKee & Dominique Tepper, 28MAY2022
* *******************************************************************************************/

namespace InventoryMaintenance
{
    public class InvItem
    {
        private int itemNo;
        private string description;
        private decimal price;

        //2-C, i. empty constructor
        public InvItem() { }

        //2-C, ii. constructor with 3 parameters
        public InvItem(int itemNo, string description, decimal price)
        {
            this.ItemNo = itemNo;
            this.Description = description;
            this.Price = price;
        }

        //2-A. Read/Write properties
        public int ItemNo 
        { 
            get
            {
                return itemNo;
            }
            
            set
            {
                itemNo = value;
            }
        }
        public string Description 
        {
            get
            {
                return description;
            }
                
            set
            {
                description = value;
            }
        }
        public decimal Price 
        { 
            get
            {
                return price;
            } 
            
            set
            {
                price = value;
            }

        }

        //2-B. GetDisplayMethod()
        public string GetDisplayText() 
        {
            return itemNo + "    " + description + " "
                + price.ToString("c");
        }
    }
}