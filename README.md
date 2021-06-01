# messagebox Custom Classes / Forms

# Step 1:
* Clone this project and load into Visual Studio
* Build this project

# Step 2:
* Add MyMessageBox.dll file in your current project References
* Add namespace of MyMessageBox in your Class

**using MyMessageBox;**

* Call Show() function using Class name.

There are three types of message box available
* MessageBoxNotify
* MessageBoxOk
* MessageBoxYesNo

# MessageBoxNotify
MessageBoxNotify show notification message and then hide automatically.

# MessageBoxOk
MessageBoxOk show notification message and then wait for Ok click response.

# MessageBoxYesNo
MessageBoxYesNo show notification message and then wait for Yes / No click response.

**For Example**
MessageBoxNotify.Show("message", "title", MessageBoxType.INFO);
**or**
MessageBoxOk.Show("message", "title", MessageBoxType.INFO);
**or**
MessageBoxYesNo.Show("message", "title", MessageBoxType.INFO);
