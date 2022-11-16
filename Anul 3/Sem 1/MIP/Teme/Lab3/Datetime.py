import datetime
from os import system

# Age finder

year = int(input("Enter the year of your birthday: "))
month = int(input("Enter the month of your birthday: "))
day = int(input("Enter the day of your birthday: "))

birthdayDate = datetime.datetime(year, month, day)
birthday = birthdayDate.strftime("%d/%m/%Y")
test = datetime.datetime.now() - birthdayDate

system('cls')

print(f"Your birthday: {birthday}")
print(f"You have lived for {test.total_seconds()} seconds")
