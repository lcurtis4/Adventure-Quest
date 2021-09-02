Phase 4
I don't know if you noticed, but our adventurer is naked. What happened to all that talk about a brightly colored robe and shiny hat?

In this phase we'll add the robe.

Create new file called Robe.cs.
Inside the file define a Robe class.
The class should have the following mutable properties.
Colors - a list of strings to hold the colors of the robe
Length - an integer describing the length of the robe in inches
The class should not contain any methods or constructors.
Add a new immutable property to the Adventurer class called ColorfulRobe. The type of this property should be Robe.
Add a new constructor parameter to the Adventurer class to accept a Robe and to set the ColorfulRobe property.
Add a new method to the Adventurer class called GetDescription. This method should return a string that contains the adventurer's name and a description of their robe.
In Program.cs create a new instance of the Robe class and set its properties.
Pass the new Robe into the constructor of the Adventurer.
Before the adventurer starts their challenge, call the GetDescription method and print the results to the console.
Phase 5
Let's cover that hatless head.

Create a new class called Hat in its own file.
Add a mutable integer property called ShininessLevel to indicate how shiny the hat is.
Add a computed string property called ShininessDescription to return a text description of the hat's shininess according to the following rules.
A ShininessLevel less than 2 should be "dull"
A ShininessLevel between 2 and 5 should be "noticeable"
A ShininessLevel between 6 and 9 should be "bright"
A ShininessLevel greater than 9 should be "blinding"
Add a Hat property and constructor parameter to the Adventurer class.
Update the Adventurer's GetDescription method to include the description of the hat.
Update the Program.cs file to create a Hat and pass it to the Adventurer's constructor.
Phase 6
When you think about it, this isn't much of a quest, is it? A quest is supposed to be for something, right?

Let's create a prize to give our adventurer at the end of the quest. Of course the value of the prize should reflect the awesomeness of the adventurer.

Create a new class called Prize.
Create a private field in the class called _text to contain a textual description of the prize.
Create a constructor in the class that takes a text parameter and uses it to set the _text field.
Create a method in the class called ShowPrize.
The method should accept an Adventurer as a parameter.
If the adventurer's Awesomeness is greater than zero, write the _text field to the console the same number of times as the value of the Awesomeness property.
If the adventurer's Awesomeness is zero or less than zero, write a message of pity to the console.
In Program.cs create an instance of the Prize.
At the end of the quest (before you ask if the user wants to repeat the quest) call the ShowPrize method.
Phase 7
Let's make the challenges a little more interesting. Add 2 to 5 more challenges to the program and then add code to randomly select 5 challenges for our adventurer to face. If the user chooses to repeat the quest another random selection of challenges should happen.

Phase 8
Add code to record the number of successful challenges the adventurer completes during a quest. If the user chooses to repeat the quest, multiply this number by 10 and add it do the initial Awesomeness of the adventurer on their next quest.
