--#regolith
-- using lua file extension for syntax highlighting

require System.Linq


-- defines a type Chargable that has a member of type (self, number) -> bool named 'charge'
type Chargable has
    (self, number) -> bool charge
end

-- defines a type Card that is a union of type Chargable and 
-- a type definition that has members of type string named 'apiToken' and 'currencyCode'
type Card is Chargable has
    string apiToken
    string currencyCode    
end

-- defines a type Cash that is a union of type Chargable and
-- a type definition with members 'ammount' and 'currencyCode'
type Cash is Chargable has
    number ammount
    string currencyCode    
end

-- defines a type AcceptedPayments that is the intersection of Card and Cash
-- it is garunteed to have members (self, number) -> bool charge and string currencyCode
type AcceptedPayments is Card or Cash end

type Customer has
    string name
    string email
    AcceptedPayments[] paymentMethods
end 

-- a function that gets a Cash object with the specific ammount and currency
local function getCash(number ammount, string currency) -> Cash
    -- table literal instantation with type hint to enable 'self'
    return Cash {
        ammount = ammount,
        currencyCode = currency,
        charge = function (self, number debit) 
            if self.ammount - debit > 0 then
                self.ammount = self.ammount - debit
                return true
            else
                return false
            end
        end
    }
end

local function createBob() -> Customer
    return Customer {
        name = "Bob",
        email = "bob@example.com",
        paymentMethods = { 
            -- call a function that is known to return an object of type Cash
            getCash(100, "USD"),                         
            Card { apiToken = "abc123", currencyCode = "USD", charge = (self, number ammount) => true }
        }
    }
end

-- create bob
local bob = createBob()

-- charge bob $10 for his latte 
do
    local paid = false
    for method in bob.paymentMethods do
        if method:charge(10) then
            paid = true
            break
        end
    end
    assert(paid)
end

-- use linq to charge bob $12 for existing
do
    local successful = bob.paymentMethods:FirstOrDefault( (method) => method:charge(12) )    
    assert(successful ~= nil)
end


----------------------------------------------------------------------------------------------------------------


type Person has
    string name
end

type Moveable has
    string location
    (self, Person, string) move
end

type Sittable has
    Person or nil occupant
    (self, Person) sit
end

type Jar of T is Moveable has
    T contents
end

type Jam has
    number age
    string flavor
end

type Couch is Moveable and Sittable has
    string name
end

function CreateCouch(string name, string location) -> Couch
    return Couch {
        name = name
        location = location
        sit = function (self, Person person)
            if self.occupant exists then
                print(self.occupant.name .. " is already sitting in this couch")
            else            
                self.occupant = person
                print(person.name .. " is now sitting in this couch")
            end
        end,
        move = function(self, string location) 
            print("Moving the couch from " .. self.location .. " to " .. location)
            self.location = location
        end
    }
end

local Person bob = { name = "Bob" }

local var couch = CreateCouch{ name = "The Obliterator", location = "Living Room" }

couch:move(bob, "Throne Room")

couch:sit(bob)

local var jar = Jar of Jam {
    contents = Jam {
        age = 1, 
        flavor = "turnip"
    },
    move = function(self, Person person, string location) 
        print(person.name .. " has moved this Jar of " .. self.contents.flavor .. " jam to " .. location)
    end
}


