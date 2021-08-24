# Custom Message Box, Custom Designed
Custom message box is a windows form application. Displays a message window, also known as a dialog box, which presents a message to the client. 
A CustomMessageBox can contain three kinds of message boxes which show diffrent style of message dialogues

# Step 1:
* Clone this project and load into Visual Studio
* Build this project

![image](https://user-images.githubusercontent.com/43881236/130598983-c83d1d36-be2e-47dd-8498-df4bd53bd7a4.png)

**using MyMessageBox;**

* Call Show() function using Class name.

There are three types of message box available
* MessageBoxNotify  
* MessageBoxOk
* MessageBoxYesNo

# MessageBoxNotify
MessageBoxNotify show notification message and then hide automatically.

![image](https://user-images.githubusercontent.com/43881236/130599290-d6ef05cd-b244-4dcd-9db2-6ec834d921c6.png)

# MessageBoxOk
MessageBoxOk show notification message and then wait for Ok click response.

![image](https://user-images.githubusercontent.com/43881236/130599344-25eda0f1-135b-40cb-999b-d7a3e2f19bf2.png)

# MessageBoxYesNo
MessageBoxYesNo show notification message and then wait for Yes / No click response.

![image](https://user-images.githubusercontent.com/43881236/130599405-481fe440-da67-4d41-a2e1-95196ae4f409.png)

# For Example

MessageBoxNotify.Show("message", "title", MessageBoxType.INFO);

MessageBoxOk.Show("message", "title", MessageBoxType.INFO);

MessageBoxYesNo.Show("message", "title", MessageBoxType.INFO);
