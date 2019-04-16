# SleepDebtCalculator_Practice
A practice activity using TDD.


In this activity, you are going to build a sleep debt calculator using TDD.  To simulate a situation you may encounter on the job, the tests have been written for you, and your job it to write the code to make them pass.  There is one user story, but you will need to write multiple functions for your calculation algorithm (as outlined by the unit tests).  Keep SOLID design principles in mind as you write.
User Story

	Users should be able to input their age and the hours they slept each night of the week and then have their slept debt or surplus printed to the console.

Notes: 
	- The hours of sleep required by age have been modified from sleep data for the sake of ease: 
		o	Children 13 and younger need 10 hours
		o	Teens between 14 and 19 need 9 hours
		o	Anyone 20 or older will needs 20 hours of sleep.

	-	The program class calls your master function to run your program.  You need to write this method (it’s not tested explicitly through unit tests).

	-	Two helper function have been written for you in a static UserInterface class.  Make sure to use them to get a user’s input.

Extra: Add functionality (with needed unit tests) to allow users to input their own range of day to calculate (ex: 7 days, 10 days, 1 month, etc.)
