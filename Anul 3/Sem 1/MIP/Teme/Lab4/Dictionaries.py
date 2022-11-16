# Search for the highest age from an agenda
agenda = [{"name": "Raul", "age": 21, "nationality": "RO"},
          {"name": "Andreea", "age": 21, "nationality": "RO"},
          {"name": "Albert", "age": 59, "nationality": "GB"},
          {"name": "Hans", "age": 16, "nationality": "DE"},
          {"name": "Istvan", "age": 33, "nationality": "HU"}]

maxAge = max(agenda, key=lambda x: x['age'])["age"]

print(f"The highest age from the whole agenda is {maxAge}")
