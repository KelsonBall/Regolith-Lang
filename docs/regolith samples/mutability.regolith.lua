-- variables can be declared 'constant', making them immutable
constant number pizzas = 3

-- ERROR: attempt to mutate global constant 'pizzas'
pizzas = 4

-- contants can still be referenced-over in local scopes
do
    local pizzas = pizzas - 1 -- *reads* pizzas from parent scope and modifies local 'pizzas'
    assert(pizzas, 2)
end
assert(pizzas, 3)

-- constants can be local
do
    local constant pizzas = pizzas - 1 -- reads pizzas from parent scope and assigns to local constant with the same key
    assert(pizzas, 2)
    
    -- ERROR: attempt to mutate local constant 'pizzas'
    pizzas = pizzas - 1
end

-- example type
type BagleShop has 
    number bagles
    (self, number) -> () addBagles
    pure (self, number) -> number inventoryValue -- pure functions have only constant parameters and cannot access global or parent scopes
end

local BagleShop my_shop = {
    "bagles" = 10,
    "addBagles" = function (self, number newBagles)
        self.bagles = self.bagles + newBagles
    end,
    "inventoryValue" = pure function(self, number value) -> number
        return self.bagles * value
    end
}

-- references marked 'constant' point the mutable reference to the constant one as the mutable references data source
local constant BagleShop frozen_shop = my_shop
assert(my_shop.bagles, frozen_shop.bagles) -- both reads of 'bagles' will actually get their values from the same place

my_shop.bagles = 4 -- the mutable reference 'pushes' a new value for the 'bagles' key
assert(frozen_shop.bagles, 10)
assert(my_shop.bagles, 4)

local constant BagleShop frozen_shop_2 = my_shop
my_shop.bagles = 128
assert(frozen_shop.bagles, 10)
assert(frozen_shop_2.bagles, 4)
assert(my_shop.bagles, 128)

-- aliases to values obtained from constant references must also be constant
-- ERROR: attempt to assign constant 'bagles' to mutable local 'bagles'
local bagles = frozen_shop.bagles
-- works:
local constant bagles = frozen_shop.bagles

-- constant references to impure functions cannot be invoked
local constant bagleAdder = frozen_shop.addBagles
-- ERROR: cannot invoke constant impure function 'bagleAdder'
bagleAdder(my_shop, 3)

-- constant references to pure functions **can** be invoked
local constant inventoryGetter = frozen_shop.inventoryValue
-- works:
inventoryGetter(my_shop, 3.40)

-- function parameters can be declared constant, preventing complex types from being mutated
function printBagelCount(constant BagleShop shop)
    print("Bagles: " .. shop.bagles)

    -- ERROR: cannot invoke constant impure function 'addBagles'
    shop:addBagles(2)

    -- works:
    print("Worth: $" .. shop:inventoryValue(3.40)) -- pure methods can be called from constant references, and their results will also be constant
end
