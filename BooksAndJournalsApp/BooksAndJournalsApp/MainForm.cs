﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BooksAndJournalsApp.DataContainer;

namespace BooksAndJournalsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            Book book = new Book();
            Book book1 = new Book();
            Book book2 = new Book();
            Book book3 = new Book();
            Book book4 = new Book();
            Book book5 = new Book();
            Book book6 = new Book();

            book.Author = "J. K. Rowling";
            book.Title = "Harry Potter and the Philosopher's Stone";
            books.Add(book);

            book1.Author = "J. K. Rowling";
            book1.Title = "Harry Potter and the Chamber of Secrets";
            books.Add(book1);

            book2.Author = "J. K. Rowling";
            book2.Title = "Harry Potter and the Prisoner of Azkaban";
            books.Add(book2);

            book3.Author = "J. K. Rowling";
            book3.Title = "Harry Potter and the Goblet of Fire";
            books.Add(book3);

            book4.Author = "J. K. Rowling";
            book4.Title = "Harry Potter and the Order of the Phoenix";
            books.Add(book4);

            book5.Author = "J. K. Rowling";
            book5.Title = "Harry Potter and the Half-Blood Prince";
            books.Add(book5);

            book6.Author = "J. K. Rowling";
            book6.Title = "Harry Potter and the Deathly Hallows";
            books.Add(book6);


            Journal journal = new Journal();
            Journal journal1 = new Journal();

            journal.Title = "Nature";
            journal.Author = "C. Davisson and L. H. Germer;J. Chadwick;L. Meitner and O. R. Frisch;J. D. Watson and F. H. C. Crick;J. C. Kendrew, G. Bodo, H. M. Dintzis, R. G. Parrish, H. Wyckoff, D. C. Phillips;J. Tuzo Wilson;A. Hewish, S. J. Bell, J. D. H. Pilkington, P. F. Scott & R. A. Collins;J. C. Farman, B. G. Gardiner and J. D. Shanklin;I. Wilmut, A. E. Schnieke, J. McWhir, A. J. Kind and K. H. S. Campbell;International Human Genome Sequencing Consortium";
            journal.Articles = "Wave nature of particles;The neutron;Nuclear fission;The structure of DNA;First molecular protein structure (myoglobin);Plate tectonics;Pulsars;The ozone hole;First cloning of a mammal;The human genome";
            journals.Add(journal);

            journal1.Title = "Proceedings of the Royal Society";
            journal1.Author = "Dirac, P. a. M.;Heisenberg, W.;Oliphant M. L. E., Kempton A. E., Rutherford Lord;Schrodinger, E.";
            journal1.Articles = "Quantised Singularities in the Electromagnetic Field;On the Theory of Statistical and Isotropic Turbulence;Some Nuclear Transformations of Beryllium and Boron, and the Masses of the Light Elements;The Wave Equation for Spin 1 in Hamiltonian Form. II";
            journals.Add(journal1);

            InitializeComponent();
            BookViewer.DataSource = books;
            JournalViewer.DataSource = journals;
        }

        private void authorsWorksBtn_Click(object sender, EventArgs e)
        {
            SearchForm form = new SearchForm();
            form.Show();
        }
    }
}
