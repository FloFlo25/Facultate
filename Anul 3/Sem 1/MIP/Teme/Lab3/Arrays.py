# Insert in a hardcoded list of Cities another name of a city

cities = ["Oradea", "Rome", "Timisioara", "Greece"]

cityInput = input("Insert another name of a city you visited: ")

cities.append(cityInput)

print(f"The list of cities (nmb of cities: {len(cities)}): ", *cities)
