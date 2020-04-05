distanceInKm = int(input("Enter distance in Km: "))
kmPerLitreEstimate = int(input("Enter the Km per litre estimate of the car: "))
averageCostPerLitre = int(input("Enter the average cost per litre: "))

print()

def estimatedCostOfTrip(numberOfLitresRequired, averageCostPerLitre):
	estimatedCost = (numberOfLitresRequired * averageCostPerLitre)
	print("Estimated Cost Of Trip: $" + str(estimatedCost))

def numberOfLitresRequired(distanceInKm, kmPerLitreEstimate):
	numberOfLitresRequired = (1/kmPerLitreEstimate) * distanceInKm
	print("Number of litres of fuel required: " + str(numberOfLitresRequired) + "L")
	estimatedCostOfTrip(numberOfLitresRequired, averageCostPerLitre)

numberOfLitresRequired(distanceInKm, kmPerLitreEstimate)
