﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lateFeeCalcPart1
{
    public class RentalItem
    {
        private int movieNo;
        private string description;
        private string rating;

        public RentalItem() { }

        public RentalItem(int movieNo , string description, string rating)
        {
            this.movieNo = movieNo;
            this.description = description;
            this.rating = rating;
        }

        public int MovieNo
        {
            get
            {
                return movieNo;
            }
            set
            {
                movieNo = value;
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

        public string Rating
        {
            get
            {
                return rating;
            }
            set
            {
                rating = value;
            }
        }

        public string GetDisplayText()
        {
            return movieNo + "\t " + description + "- " + rating;
        }

    }

}
