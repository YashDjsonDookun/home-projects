print ("Please choose a city from Los Angeles, Tampa, Pittsburgh or Charlotte.")

def hotel_cost(nights):
    #Assuming that the hotel costs $140/nights
    return 140 * nights

def plane_ride_cost(city):

    if city == "Charlotte":
        return 183
    elif city == "Tampa":
        return 220
    elif city == "Pittsburgh":
        return 222
    elif city == "Los Angeles":
        return 475

def rental_car_cost(days):
    cost = days * 40
    if days >= 7:
        cost -= 50
    elif days >= 3 and days < 7:
        cost -= 20
    return cost

def trip_cost(city, days, spending_money):
    return rental_car_cost(days) + hotel_cost(days - 1) + plane_ride_cost(city) + spending_money

city = str(raw_input("Enter City: "))
days = int(raw_input("Enter number of Days: "))
spending_money = int(raw_input("Enter amount of Spending Money: "))

print ("Your Total Cost for this trip is:"), trip_cost(city, days, spending_money)
