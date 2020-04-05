class StudentMarks(object):
	def __init__(self):
		numberOfStudents = int(input("Enter the number of Students: "))
		numberOfSubjects = int(input("Enter the number of Subjects: "))
		print()

		# Create and initialise the array
		arrStudSubjects = [[0 for i in range(numberOfSubjects)] for j in range(numberOfStudents)]

		# Populate Array based on user input
		def PopulateArray():
			for i in range(numberOfStudents):
				print("Entering marks for Student " + str(i+1) +"...")
				for j in range(numberOfSubjects):
					arrStudSubjects[i][j] = int(input("Enter marks for Subject "+ str(j+1) +": "))
				print()
			return arrStudSubjects
		PopulateArray()

		# Display contents of the array
		def DisplayContentsOfArray():
			print("Displaying the contents of the 2D Array:")
			for x in arrStudSubjects:
				print(x)
		DisplayContentsOfArray()

		def ShowProcessedInfo():
			for i in range(numberOfStudents):
				min, max, average, total = (arrStudSubjects[i][0], arrStudSubjects[i][0], 0.0, 0)
				print()
				print("Processed Marks for Student " + str(i+1) +"...")
				for j in range(numberOfSubjects):
					if (min >= arrStudSubjects[i][j]):
						min = arrStudSubjects[i][j]
					if (max <= arrStudSubjects[i][j]):
						max = arrStudSubjects[i][j]
					total += arrStudSubjects[i][j]
				average = (total / numberOfSubjects)
				print("min: " + str(min))
				print("max: " + str(max))
				print("total: " + str(total))
				print("average: " + str(average))
				print()
		ShowProcessedInfo()

students = StudentMarks()