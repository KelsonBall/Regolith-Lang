This document is a work-in-progress

# Regolith

## Summary

This is the language specification for the Regolith Scripting Language.
Regolith is a language designed to take the accesability and embeddability of Lua and add tools and feautres that improve portability, scalability, and accesability. 

## Contents

 * Language Overview
    * Concepts
        * Data
        * Assignments
        * Scope
        * Control
        * Functions
        * Collections
        * Types
        * Modules
        * Error handling
    * Grammar
        * Chunks
        * Blocks
        * Statements
        * Expressions
        * Functions
        * Collections
        * Literals
 * Tooling
    * Summary
    * dotnet global tools
    * parsing and compilation
    * interpreter
    * debugging
    * Regolith editor

## Language Overview

### Data

Data in Regolith programs are expressed with value literals, or as combinations of data as covered in `Collections` and `Types`

#### Nil Literal

The absence of a value is represented in Lua and Regolith with `nil`

```lua
nil
```

#### Boolean Literals

Boolean values can either be `true` or `false`
```lua
true
false
```

#### Number Literals

Numbers are expressed as strings of digits with or without delimeters and with or without a numeric base specifier.

A simple decimal integer 
```lua
1
```

A floating point decimal number
```lua
1.2
```

Floating point numbers with an exponent (3.14 and 1.0)

Exponents start with `+` or `-` followed by an integer
```lua
31.4-2
0.01+3
```

Hexidecimal numbers (127, 15, and 65535) are prefixed with `0x` or `0X`
```lua
0x7F
0xf
0Xffff
```

A binary number
```lua
0b1101
```

Numbers with `_` seperators (these do not effect the value of the number)
```lua
-- unique to Regolith
100_000_000.0
0x66_33_99
0b1010_0100
```

#### String Literals

A simple string with double quotes (`"`)
```lua
"Hello, World"
```

A string with single quotes (`'`)
```lua
'Hello, World'
```

Strings with one delimeter can contain the other
```lua
"This is a single quote: ' "
'This is a double quote: " '
```

### Assignments

Variables can be assigned with the `=` operator
Assignments have a list of `identifier`s followed by a list of `expression`s

An assignment of a single value to a single identifier
```lua
x = 3

-- State:
--{
--  x = 3
--}
```


An assignment of multiple values to multiple identifiers
```lua
x, y = 3, 4

-- State:
--{
--  x = 3
--  y = 4
--}
```

Variables are read from the current scope using their identifier

Assigning one variable to the value of another
```lua
x = 3
y = x

-- State:
--{
--  x = 3
--  y = 3
--}
```

### Scope

A variable can be constrained to a specific scope using a `block`

```lua
x = 3

-- State:
--{
--  x = 3
--}

do
    y = 4
-- State:
--{
--  {
--      y = 4
--  }
--  x = 3
--}
end

-- State:
--{
--  x = 3
--}
```

By default, variables in 'outer' or 'parent' scopes can be mutated

```lua
x = 3
do
-- State:
--{
--  {
--  }
--  x = 3
--}
    x = 4
-- State:
--{
--  {
--  }
--  x = 4
--}
end
-- State:
--{
--  x = 4
--}
```

Variables can be marked `local` to specify that they exist in the inner scope and 'override' values in the outer scope

```lua
x = 3
y = 0
do
-- State:
--{
--  {
--  }
--  x = 3
--  y = 0
--}
    local x = 4
-- State:
--{
--  {
--    x = 4
--  }
--  x = 3
--  y = 0
--}
    y = x
 -- State:
--{
--  {
--    x = 4
--  }
--  x = 3
--  y = 4
--}   
end
-- State:
--{
--  x = 3
--  y = 4
--}
```

### Control

Basic control flow in Regolith is handled with traditional `if` statements for branching and `for` and `while` loops for iteration.


#### Branching

A basic if statement in Regolith has the structure 
```lua
if condition then
    -- block
end
```

```lua
local count = 0
-- State:
--{
--  count = 0
--}
if false then
    count = count + 1
end
-- State:
--{
--  count = 0
--}
if true then
    count = count + 1
end
-- State:
--{
--  count = 1
--}
```

Control structures have their own scopes

```lua
local x = true
if x then
    local x = 2
-- State:
--{
--  {
--    x = 2
--  }
--  x = true
--}
end
```

If statements can be expanded with `else` and `elseif` clauses

```lua
local x = nil
if x then
    -- does not get executed
elseif not x then
    -- does not get executed
    -- this differs from Lua, where 'nil' evaluates as false
    -- in Regolith *only* true is true, and *only* false is false
else
    -- this gets executed
end
```


The condition expression must have type `bool` or `any`, unless `any` has been disallowed by the tooling, in which case it must be of type `bool`.
If `any` is allowed by the tooling and at runtime the condition does not evaluate to `bool` then an exception will be thrown.

If statements with expressions look like this

```lua
local x = 3
if x == 3 then -- binary equality expression
    -- evaluated if x is 3
elseif x < 2 then   
    -- evaluated if x is not 3 and is less than 2
elseif x > 4 then
    -- evaluated if x is not 3 and is not less than 2 and is greater than 4
else
    -- evaluated if all previous conditions failed
end

if x ~= 2 then -- binary inequality expression
end

if y exists then -- shorthand for '~= nil`, Regolith specific
end

if x exists or y exists then -- comparing 2 boolean expressions with a logical or
end
-- (short circuit evaluation and operator precedence are covered in the chapter on expressions)
```

#### Loops

There are 4 loop structures in Regolith
 * while condition
 * repeat until condition
 * for range
 * for in iter

#### While Loops

While loops have the structure
```lua
while condition do
    -- statements
end
```

Example of using a while loop to count down a variable to 0
```lua
local x = 4
while x > 0 do
    x = x - 1
end
--State
--{
--  x = 0
--}
```

The `break` and `continue` keywords behave the same in all loop types.
 * `break` exits the loop
 * `continue` skips to the head of the loop, evaluating any conditions or iterators at the head

In while loops, the behavior of `break` and `continue` looks like this
```lua

local x = 4
while true do -- without the break keyword this loop would never exit
    x = x - 1 -- decrement x
    if x <= 0 then -- if x is less than or equal to 0
        break -- exit the loop
    end
end

local y = false
local x = 3;
while x > 0 do -- while x is greater than 0
    if not y then -- if y is false
        y = true -- assign true to y
        continue -- skip back to start of loop
    end
    x = x - 1 -- decrement x    
end
```
#### Repeat Loops

Repeat until conditition loops in Regolith and Lua behave similarly to while loops. Most languages call these 'do while' loops. They differ from while loops in that the loop body is always evaluated at least once, and is evaluated before the condition is tested.

Structure of a repeat until loop
```lua
repeat
    -- statements
until condition
```

Here is an example of counting down a variable to demonstrate the difference
```lua

local x = -2
--State
--{
--  x = -2
--}

while x > 0 do
    x = x - 1 -- x > 0 evaluated to false, so this statement is not executed
end
--State
--{
--  x = -2
--}

local x = -2
repeat 
    x = x - 1 -- statement is executed before condition is tested
until x <= 0 -- condition evaluates to false so loop is not repeated
--State
--{
--  x = -3
--}
```

#### For range loops

Traditional for loops have the following structure
```lua
for value = from, to [, step] do
    -- statements
end
```

When the loop is encountered the loops scope is pushed, the `value` field is assigned to the value of the `from` field, and the condition `value <= to` or `value >= to` is evaluated, depending on the sign of `to`.
If the condition evaluates to true the loop body is executed and then `value` is incremented by `step`.
Step is optional and defaults to 1.

```lua
for i = 1, 3 do
    print(i) -- output the value of i
end
-- output:
--> 1
--> 2
--> 3

for i = 1, 0 do
    print(i)
end
-- output:
-- (there is none, the loop body was never evaluated)

for i = -3, 12, 4 do
    print(i)
end
-- output:
--> -3
--> 1
--> 5
--> 9

for i = 3, 1, -1 do
    print(i)
end
-- output:
--> 3
--> 2
--> 1
```

#### For in loops

For in loops enumerate all values of an IEnumerable. IEnumerable is an interface provided by the dotnet standard and has the following type definition
```
type IEnumerable of T has
    T Current
    (self) -> bool MoveNext
end
```

For in loops have the structure
```lua
for value in expression do -- expression must evaluate to an IEnumerable
    -- statements
end
```

Examples with lists
```lua
for value in [1, 2, 3] do
    print(value) -- type of value is 'any'
end
-- output:
--> 1
--> 2 
--> 3

for value in [ 1, "2" ] do
    print(value) -- type of value here still 'any'
end
-- output:
--> 1
--> 2

local IEnumerable of number or string data = [ 1, "2" ] --[[ NOTE use var to "infer narrowest type" and allow in generics for "IEnumerable of var" syntax? ]]
for value in data do
    print(value) -- type of value is the intersection of number and string
end
-- output:
--> 1
--> 2
```

Tables are dotnet Dictionary types, and are collections of key-value pairs.
The following type definition applies to Tables
```
type KeyValuePair of TKey, TValue has
    TKey key
    TValue value
end

type Table of TKey, TValue is IEnumerable of KeyValuePair of TKey, TValue end
```

For in loop examples with tables

```lua
for pair in { "x" = 2, "y" = 3 } do
    print(pair.key, pair.value)
end
-- output:
--> x   2
--> y   3

for pair in { "a", "b", "c" } do
    print(pair.key, pair.value)
end
-- output:
--> 1   "a"
--> 2   "b"
--> 3   "c"

```

Traditional lua iterators are functions that return either a value or `nil` and can be converted into enumerables using the `enumerable` built in function

```
local iterator = ipairs({1, 2, 3})
local dotnet_enumerable = enumerable(iterator)
```

Collections in Regolith are IEnumerables, so they can
## Tooling


### Summary

The core of Regolith will be implemented with a parser and interpreter implemented in netstandard 2.0, and will inherit the dotnet ecosystems package management, project structure, and runtimes.

Other compilation targets will be implementable from the output of the dotnet tooling.

### Using dotnet global tools

todo

