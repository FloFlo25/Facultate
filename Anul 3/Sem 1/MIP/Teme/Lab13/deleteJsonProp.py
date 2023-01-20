# Make a python program that deletes the abbreviation property from the 'states.json'

import json

with open('C:/Users/raulb/Code/Facultate/Anul 3/Sem 1/MIP/Teme/Lab13/states.json') as f:
  state_data= json.load(f)

for state in state_data['states']:
  del state['abbreviation']

with open('C:/Users/raulb/Code/Facultate/Anul 3/Sem 1/MIP/Teme/Lab13/new_states.json', 'w') as f:
  json.dump(state_data, f, indent=2)