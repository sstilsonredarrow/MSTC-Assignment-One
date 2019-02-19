# MSTC-Assignment-One
First assignment for intermediate mobile class
Intro to MvmCross

Assignment One (50 Points) 
Due: March 4th

For your first assignment here is what you will need to do:
- Have a main page(XAML) that the user first comes to.  that is an MvxContentPage, setting up the XAML and the code behind appropriately to use the MvvM namespace.  This is the way we have done all the code up to this point so you should have examples.

This page needs to have a corresponding ViewModel associated with it, but no service.  It should have a welcome label that is bound to the ViewModel string property.  It should also have a button that has an MvxCommand bound to it in the XAML with the MvxCommand defined in the ViewModel.  This can be an MvxAsyncCommand too if you would like to make it async like we did in class.

The main view model will need to have the IMvxNavigationService injected into the constructor and use it to navigate to the next view model.

Tapping the button (button should say "Look at my list" or something like that) will take the user to the next screen, defined below.

- Add a 2nd UI (XAML) page 
  - The UI should display a list of (movies, games, foods, pasttimes, etc), whatever you like in a ListView.
  - Each ListView cell should have a title of whatever the item is and a subtitle UNDER the title. The subtitle should be a brief      description of the object.
  - The ViewModel should have a List<someobject_you_name> of your objects you will bind to the list
  - You will need to create a Services folder with an interface and implementation file for your service
  - The service should supply you with the list of objects.
  - The list of objects needs to be bound to the ListView's ItemsSource property
  - Style the listview to have the background color of your choosing and a complimentary text color to compliment it.
  
  That's it!  Happy coding!
  - 
