using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace RecipeCollector.Models{
    public abstract class NotifyableClass : INotifyPropertyChanged{
        #region Notifications
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Raises a PropertyChanged event for the specified property.
        /// </summary>
        /// <param name="propertyName">Name of the changed property</param>
        protected void RaisePropertyChanged(string changedPropertyName){
            if (PropertyChanged != null){
                PropertyChanged(this, new PropertyChangedEventArgs(changedPropertyName));
            }
            Console.WriteLine("Changed Property " + changedPropertyName);
        }
        #endregion
    }
}
