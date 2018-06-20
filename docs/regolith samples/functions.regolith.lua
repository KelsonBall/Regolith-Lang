-- a pure function takes 0 or more constant parameters and returns 0 or more results
-- it does not have access to global or parent scopes
-- pure functions that have 0 return values can't do anything by definition, so can be safely ignored by interpreters and compilers
local pure function add(number a, number b) -> number
    return a + b;
end
assert(type(add), type( pure (number, number) -> number) ) -- type literals for pure functions are prefixed with the 'pure' keyword
assert(add(1, 2), 3)

-- a partial function will return a new function when called without all of its parameters
local partial function concat(string a, string b) -> string
    return a .. b
end

-- passing all parameters behaves exactly like normal functions
assert(concat("a", "b"), "ab") 

-- passing fewer returns a new function "loaded" with the passed parameters
local hello = concat("Hello, ")
assert(type(hello), type((constant string) ?> string)) -- type literals for partial functions use '?>' instead of '->'
assert(hello("World"), "Hello, World")
assert(hello("Moon"), "Hello, Moon")

-- pure functions can be partial, providing an alternative to clojures
local pure partial function add3(number a, number b, number c) -> number
    return a + b + c
end

assert( type(add3), type( pure (number, number, number) ?> number) )
local add2 = add3(1)
assert(add2(4, 5), 1 + 4 + 5)

local add1 = add2(2)
local sum123 = add1(3)
assert(sum123, 1 + 2 + 3)

local sum456 = add3(4)(5)(6)
assert(sum456, 4 + 5 + 6)

local sum789 = add3(7, 8)(9)
assert(sum789, 7 + 8 + 9)

-- partial functions that take parameter lists will evaluate when called without arguments
local pure partial function sum(number ...) -> number
    local sum = 0
    for value in [...] do
        sum = sum + value
    end
    return sum
end

local sum24 = sum(2)(4)
assert(type(sum24), type( pure (constant number ...) ?> number) )
assert(sum24(), 2 + 4)
asssert(sum24(8)(), 2 + 4 + 8)
local list = { 4, 5 }
local sums = sum(1, 2, 3)( |list| ) -- |collection| as unpack operator? (⌐■_■)
assert(sums(), 1 + 2 + 3 + 4 + 5)





