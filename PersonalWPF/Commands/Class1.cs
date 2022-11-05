using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace PersonalWPF.Commands
{
    public class DataCommands
    {
        
        public static RoutedCommand Delete { get; set; }
        public static RoutedCommand Edit { get; set; }
        static DataCommands ()
        {
            InputGestureCollection input = new InputGestureCollection ();
            input.Add(new KeyGesture(Key.E, ModifierKeys.Control, "Ctrl+E"));
            Edit = new RoutedCommand("Edit", typeof(DataCommands), input);
            input= new InputGestureCollection ();
            input.Add(new KeyGesture(Key.E, ModifierKeys.Control, "Ctrl+D"));
            Delete = new RoutedCommand("Delete", typeof(DataCommands), input);
            input = new InputGestureCollection();
            input.Add(new KeyGesture(Key.E, ModifierKeys.Control, "Ctrl+N"));
            Delete = new RoutedCommand("New", typeof(DataCommands), input);
            input = new InputGestureCollection();
            input.Add(new KeyGesture(Key.E, ModifierKeys.Control, "Ctrl+Z"));
            Delete = new RoutedCommand("Undo", typeof(DataCommands), input);
            input = new InputGestureCollection();
            input.Add(new KeyGesture(Key.E, ModifierKeys.Control, "Ctrl+S"));
            Delete = new RoutedCommand("Save", typeof(DataCommands), input);
            input = new InputGestureCollection();
            input.Add(new KeyGesture(Key.E, ModifierKeys.Control, "Ctrl+F"));
            Delete = new RoutedCommand("Find", typeof(DataCommands), input);

        }
        private bool isAvailbe = false;
        private void FindCommandBindings_Executed(object sender, ExecutedRoutedEventArgs e )
        {
            MessageBox.Show("Найти");
            isAvailbe = true;
        }
        private void AddCommandBindings_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Добавить");
            isAvailbe = true;
        }

        private void EditCommandBindings_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Редактировать");
            isAvailbe = true;
        }

        private void DeleteCommandBindings_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Удалить");
            isAvailbe = true;
        }
        private void UndoCommandBindings_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Отменить действие");
            isAvailbe = true;
        }

        private void SaveCommandBindings_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Сохранить");
            isAvailbe = true;
        }
        private void EditCommandBindings_CanExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            //e.CanExecute = isAvailbe;
        }

        private void SaveCommandBindings_CanExecuted(object sender, ExecutedRoutedEventArgs e)
        {
            //e.CanExecute = !isAvailbe;
        }
    }
}
