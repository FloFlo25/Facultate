class Vehicle:
    def __init__(self, brand: str, model: str, max_speed: int, mileage: int, capacity: int):
        self.brand = brand
        self.model = model
        self.max_speed = max_speed
        self.mileage = mileage
        self.capacity = capacity

    def seating_capacity(self, capacity):
        return f"The seating capacity of a {self.brand} {self.model} is of {capacity} {'passenger' if (capacity == 1) else 'passengers'}"

    def fare(self) -> int:
        return self.capacity * 100

    def show_fare_price(self) -> None:
        print(f"Total vehicle fare is {self.fare()} RON")

    def __str__(self) -> str:
        return f"{self.brand} {self.model} has a top-speed of {self.max_speed} that has a mileage of {self.mileage}"


class Bus(Vehicle):
    def seating_capacity(self, capacity):
        return super().seating_capacity(capacity)

    def fare(self):
        amount = super().fare()
        amount += amount * 10 / 100
        return int(amount)


modelX = Vehicle("Tesla", "ModelX", 240, 20300, 5)
school_bus = Bus("Volvo", "C420", 100, 10000, 100)

modelX.show_fare_price()
school_bus.show_fare_price()
