# Regolith-Lang

This project contains two closely alligned porjects,

The first is to implement Lua 5.3 in dotnet and provide tools and packages for it to be used in or *as* dotnet projects, with support for importing dotnet libraries using `require`, using Lua's `:` operator to pipe to instance methods and extension methods, and treating Lua iterators as `IEnumerable<dynamic>` to allow for direct use of Linq extension methods.

The second project is a new language called Regolith that is inspired by Lua, Typescript, and F#. 

Regolith Features:

 * Keep dotnet interopability of the Lua project
 * Static type system
    * Interface style type definitions
    * Type unions and intersections
 * Fully featured pipes
    * `:` will always just move the value on its left to the first parameter of the function call on the right
    * instance methods and extension methods take 'self' as first parameter, so instances are piped to the call
 * optional immutability
    * `constant` and `local constant`
    * function parameters can be marked `constant` to disallow assignments or calling impure methods on the parameter
 * optionaly pure functions    
    * disallow access to global or parent scopes and marks parameters as constant to guarantee lack of side effects
    * example: `local pure function theFuture(Timer timer, number seconds) -> number return timer.now() + seconds end`
 * partial function application
    * calling functions without all parameters returns a new function that takes the remaining parameters
