--#regolith
-- using lua file extension for syntax highlighting

require System.Linq


-- defines a type Chargable that has a member of type (self, number) -> bool named 'charge'
type Chargable has
    (self, number) -> bool charge
end

-- defines a type Card that is a union of type Chargable and 
-- a type definition that has members of type string named 'apiToken' and 'currencyCode'
type Card is Chargable and has
    string apiToken
    string currencyCode    
end

-- defines a type Cash that is a union of type Chargable and
-- a type definition with members 'ammount' and 'currencyCode'
type Cash is Chargable and has
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
    -- table literal
    return {
        "ammount" = ammount,
        "currencyCode" = currency,
        "charge" = function (self, number debit) 
            if self.ammount - debit > 0 then
                self.ammount = self.ammount - debit
                return true
            else
                return false
            end
        end
    }
end

local function createBob()
    return {
        "name" = "Bob",
        "email" = "bob@example.com",
        "paymentMethods" = { 
            -- call a function that is known to return an object of type Cash
            getCash(100, "USD"), 
            -- create an object literal and tell the type checker you expect it to be a Card
            { "apiToken" = "abc123", "currencyCode" = "USD", "charge" = (self, number ammount) => true } as Card
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
