﻿using InvoiceRegister.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace InvoiceRegister.WPF.Views
{
	public partial class CreateWindow : Window
	{
		private readonly CreateWindowVM createWindowVM;
		public CreateWindow(CreateWindowVM createWindowVM, IServiceProvider serviceProvider)
		{
			InitializeComponent();
			this.createWindowVM = createWindowVM;
			DataContext = this.createWindowVM;
		}
	}
}
