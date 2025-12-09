 Senior WPF Interview Prep — Common Plan (Markdown Version)
 Senior WPF Interview Preparation Plan (2–3 weeks)
1️ Core WPF Engine (Deep Concepts)
Study:

DependencyProperty system

Value precedence

Metadata, callbacks

Coercion (CoerceValueCallback)

PropertyChanged callbacks

Logical vs Visual Tree

Routed events (bubble/tunnel/direct)

Binding engine internals

When bindings re-evaluate

Binding failures

BindingExpression lifecycle

Freezable objects

Senior-level questions:

Why does WPF need the DependencyProperty system?

How does WPF resolve a binding source?

Why is TemplateBinding faster than normal Binding?

How does property value inheritance work?

2️ MVVM Architecture (Enterprise-level)
Master:

ViewModel responsibilities

Commands (ICommand, RelayCommand, DelegateCommand)

Navigation patterns

Communication patterns

Mediator

EventAggregator

WeakEventManager

DI/IoC integration (Prism, Autofac, built-in DI)

ViewModel lifecycle & cleanup

Senior-level questions:

How do you open dialogs without breaking MVVM?

How do different navigation patterns affect lifetime management?

How do you avoid memory leaks in long-lived ViewModels?

View-first vs ViewModel-first + DI.

3️ Prism Framework (Enterprise Apps)
Focus on:

RegionManager

Navigation journal

Module initialization & modular architecture

View injection vs view discovery

Prism commands

DialogService

EventAggregator

Senior-level questions:

Why does Prism prevent adding the same view to a region by name?

How does Prism find ViewModels for Views?

How does region navigation caching work internally?

How do module dependencies load?

4️ XAML & Control Architecture (Advanced)
Study:

CustomControl vs UserControl

Default styles (Themes/Generic.xaml)

Template selectors

Style scoping

Merged dictionaries

Converters & MultiBindings

Attached Behaviors

Senior-level questions:

Attached Property vs Behavior: when to use each?

DataTemplate vs ControlTemplate?

Why might bindings not update even after NotifyPropertyChanged?

How would you build a reusable control library?

5️ UI Threading & Async
Master:

Dispatcher

SynchronizationContext

Async ViewModel patterns

ConfigureAwait(false) pitfalls

Updating UI from background threads

Throttling & debouncing

Senior-level questions:

How to safely marshal back to UI thread?

Why async void is dangerous in commands?

Why UI freezes when updating large collections?

6️ Performance Optimization
Study:

Virtualization

Recycling containers

Reducing layout passes

Freezing objects

Template caching

Expensive bindings optimization

Using DeferRefresh

Senior-level questions:

How to display 100,000 rows smoothly?

Why virtualization might turn off unexpectedly?

When is x:Shared="False" helpful?

7️ Interop & Platform Integration
Learn:

WebView2 scripting & events

Win32 interop (HwndHost)

WinFormsHost

DPI scaling

Drag & drop

Clipboard

Senior-level questions:

How to call JS inside WebView2 from WPF MVVM?

Why does DPI scaling distort pixel-perfect controls?

How to mix DirectX with WPF?

8️ Testability
Study:

Unit testing ViewModels

Mocking services

Testing navigation

Testing converters & behaviors

Weak event patterns

Senior-level questions:

How to test ViewModels that show dialogs?

How to test behaviors with interaction triggers?

9️ Memory Management & Diagnostics
Deep topics:

Memory leaks due to events

Static references holding DependencyObjects

Binding lifetime issues

Profiling tools

EventAggregator leak risks

Senior-level questions:

What causes typical WPF leaks?

Why do binding expressions keep objects alive?

How to debug a leak caused by commands?

10 Prep Schedule (2–3 Weeks)
Week 1

Core WPF

MVVM

Prism basics

Week 2

Navigation

Dispatcher & Async

Performance

Week 3

Memory analysis

Custom controls

Interop

Build sample project

Senior WPF Interview Question Bank (80+)
A. Dependency Properties (10)

Why does WPF use DependencyProperty instead of normal properties?

Explain the Dependency Property value precedence system.

What is CoerceValueCallback used for?

When is PropertyChangedCallback invoked and how do you avoid recursion?

Why do DependencyProperties reduce memory usage?

How does PropertyValueInheritance work?

What is the difference between DP metadata and overriding metadata?

Why can’t you store state in metadata objects?

Explain attached properties vs dependency properties.

How do you detect binding failures programmatically?

B. Data Binding System (10)

Why does a binding sometimes not update on NotifyPropertyChanged?

Explain BindingExpression lifecycle.

What is the difference between Binding, MultiBinding, and PriorityBinding?

How to debug binding failures?

Why does UpdateSourceTrigger=LostFocus exist?

Why is TemplateBinding faster than Binding?

How to bind to static properties?

How to bind to async data safely?

When should you use RelativeSource vs ElementName?

Explain value converters chaining.

C. MVVM Architecture (10)

Describe the pure MVVM approach.

How do you open dialogs using MVVM?

Explain View-first vs ViewModel-first.

How do you handle navigation in MVVM?

Why is code-behind sometimes acceptable?

How do you update UI efficiently with async commands?

What is the Weak Event Pattern and why use it?

How to structure modules in a large MVVM system?

How to share ViewModel state across views?

How to implement undo/redo in MVVM?

D. Prism Framework (15)

Explain Prism RegionManager.

Why might adding the same view twice cause an exception?

What is view discovery vs view injection?

How does Prism decide which ViewModel to use for a View?

How does Prism’s module loading work?

What is IEventAggregator and why use it?

How to prevent EventAggregator memory leaks?

Explain navigation journal.

What does KeepAlive mean in Prism navigation?

What is the role of Bootstrapper?

How to implement dialog service in Prism?

How do you unit test Prism navigation?

How do you override default view registration?

Explain ViewModelLocator conventions.

How to dynamically load modules at runtime?

E. Threading & Async (10)

Why can’t you update UI from background thread?

Explain Dispatcher and its queue.

Difference between Invoke and BeginInvoke.

How does SynchronizationContext work in WPF?

Why is async void dangerous?

How to throttle rapidly changing UI?

How do you safely update ObservableCollection from background?

Why might Task.Run freeze the UI anyway?

How to await navigation events?

How to synchronize UI loading and background loading?

F. Performance Optimization (10)

Explain UI virtualization and conditions where it breaks.

Why might virtualization disable automatically?

How to render hundreds of thousands of rows?

How to reduce layout recalculations?

Explain DeferRefresh and when to use it.

How to improve bindings performance?

How to reduce memory overhead in ItemControls?

Why Freeze() improves performance?

How does BitmapCache help?

How to optimize ControlTemplate for fast loading?

G. Controls & XAML (10)

UserControl vs CustomControl – when and why?

Why does default style require Themes/Generic.xaml?

How to override default template of a control?

ControlTemplate vs DataTemplate — key differences.

What is a template selector and where is it used?

Why do attached properties exist?

How to create a behavior without Blend SDK?

How to limit TextBox input using behavior?

How to build your own ItemsPanelTemplate?

How to implement custom routed event?

H. Memory Leaks & Diagnostics (10)

Why do events cause memory leaks?

How does EventAggregator cause leaks if used incorrectly?

Why do binding expressions sometimes keep objects alive?

Explain visual tree leaks caused by ItemsControls.

How to detect retained visuals?

How do static fields cause memory leaks?

What tools to diagnose WPF memory issues?

What is a dispatcher-affinity leak?

How to release references in Prism navigation?

How to ensure ViewModels are properly garbage-collected?

I. Interop & Integration (5)

How to call JavaScript inside WebView2?

How to receive messages from WebView2 in MVVM?

How to embed Win32 window inside WPF safely?

Why is DPI scaling tricky in WPF?

How to handle multi-monitor DPI awareness?