﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Diagnostics;

//Created by Andy- Sept 4th 2015
//main page that will greet the user.
namespace ScheduleApp
{
	// The root page of your application
	public class Main: ContentPage
	{
		public Main(){
			Title = "Scheduler App 2015";

			var AddTask = new Button {
				Text = "Add Task"
				//Font = Font.SystemFontOfSize (NamedSize.Large),
				//BorderWidth = 1,
				//HorizontalOptions = LayoutOptions.Center,
				//VerticalOptions = LayoutOptions.CenterAndExpand
			};
			AddTask.Clicked += (sender, e) => {
				var pAddTask = new pageAddTask();
				this.Navigation.PushAsync(pAddTask);
			};
			var ConfigButton = new Button { Text = "Configuration" };
            ConfigButton.Clicked += (sender, e) => {
                var pAppSettings = new pageAppConfig();
                //				var todoItem = (TodoItem)BindingContext;
                //				this.Navigation.PopAsync();
                this.Navigation.PushAsync(pAppSettings);
            };

				
			Content = new StackLayout {
				VerticalOptions = LayoutOptions.Center,
				Children = {
					AddTask,
                    ConfigButton
                }
			};
		}
	};
}

