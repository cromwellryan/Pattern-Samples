Definition: A way of augmenting an implementation by wrapping its behavior.

c2.com: Attach additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality. 
wikipedia: Allows new/additional behaviour to be added to an existing object dynamically.

Good uses
This pattern can also be used as a way to refactor a complex class into smaller pieces. Even if you don't need to attach responsibilities dynamically it can be clearer to have each responsibility in a different class. Somewhat like MixIns. -- ChristianTaubman 
Added behavior to an implementation that is not consistent with the purpose or charter of the interface.

You have an instance, and you put another instance inside of it. They both support the same (or similar) interfaces. The one on the outside is a "decorator." 


Implications on CHARTrunner
Castle Windsor provides similar infrastructure through interceptors.  We use them for Licensing now.
Would be good for logging and diagnostics.
As a replacement for inheritence on the AnalysisServices...