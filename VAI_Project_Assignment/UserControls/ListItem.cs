﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VAI_Project_Assignment
{
    public partial class ListItem : UserControl
    {
        public ListItem()
        {
            InitializeComponent();
        }

        /// <summary>
        ///  I technically should not change anything from here, however I believe that I know what I am doing (I don't.)
        ///  This ListItem class will be used as an alternative to the default list that already comes with winforms. It is prettier,
        ///  definetly not faster, and it's very likely to break. But we are here to learn.
        ///  Shoutout to this tutorial for the help: https://www.youtube.com/watch?v=cL3aO1QkgvM&t from user https://github.com/k33ptoo/ 
        /// </summary>
        private string _entryTitle;
        private string _entryType;
        private string _entryDescription;
        private Image _vendorImage;


        /// <summary>
        /// I assume that these are constructors. Since I am making my own tool, 
        /// it very likely signifies that I am naming the category of this new ListItem class.
        /// It's interesting that I understand this. Huh.
        /// </summary>


        [Category("Custom Props")]
        public string entryTitle
        {
            get { return _entryTitle; }
            set { _entryTitle = value; entryTitleLabel.Text = value; }

        }

        [Category("Custom Props")]
        public string entryType
        {
            get { return _entryType; }
            set { _entryType = value; entrySubtitleLabel.Text = value; }

        }

        [Category("Custom Props")]
        public string entryDescription
        {
            get { return _entryDescription; }
            set { _entryDescription = value; entryDescriptionLabel.Text = value; }

        }

        [Category("Custom Props")]
        public Image vendorImage
        {
            get { return _vendorImage; }
            set { _vendorImage = value; entryLogoPicture.Image = value; }
        }

    }
}
