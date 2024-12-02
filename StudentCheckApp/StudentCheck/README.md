Plan and build a Console application that asks a user for their name and their age. If their name is Bob or Sue, address them as Professor. 
If the person is under 21, recommend they wait X years to start this class.

Ask name: {firstName}
Ask age: {age}

if {firstName} = Bob or Sue

	formattedName = Professor {firstName}
else 

	formattedName = {firstName}

if age < 21 
	
	Hi {formattedName},

	I recommend you to wait {21 - age} years to start this class.

	Thanks you.
else 
	
	Hi {formattedName}.

	I am happy to let you know, you are ready to start this class.

	Thanks you.