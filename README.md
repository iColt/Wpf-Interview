Senior WPF Interview Prep — Common Plan (2–3 weeks)
1️ Refresh the Core WPF Engine (Deep Concepts)

Even seniors get asked these to check fundamentals.

Study:

DependencyProperty system

value precedence

metadata, callbacks

coercion (CoerceValueCallback)

property change notifications

Logical vs Visual Tree

Routed events (bubble/tunnel/direct)

Binding engine internals

when bindings re-evaluate

binding failures & diagnostics

BindingExpression lifecycle

Freezable objects

Senior-level questions:

Why DependencyProperty exists (memory, metadata, inheritance, performance)?

How binding engine resolves sources?

Why TemplateBinding is faster than Binding?

How PropertyValueInheritance works?

2️ MVVM Architecture (Enterprise-level)
Master:

Pure MVVM (ViewModel-only logic)

Command patterns (DelegateCommand, RelayCommand)

Navigation architectures

ViewModel communication patterns

Mediator

EventAggregator

WeakEventManager

Testability impact of design decisions

IoC/DI patterns (Prism, Autofac, built-in .NET DI)

Managing lifetime (scoped services, region navigation lifetime)

Senior-level questions:

How to open dialogs without violating MVVM?

Different patterns for navigation (PRISM, NavigationStore)?

How to avoid memory leaks in long-lived ViewModels?

ViewModel-first vs View-first with DI.

3️ Prism (common in enterprise WPF)
Focus on:

RegionManager

Navigation journal

Module initialization

Interaction requests or DialogService

Prism commands

View discovery vs View injection

Composite applications

Overriding default bootstrapping

EventAggregator mechanics

Senior-level questions:

Why region navigation caching can cause "view already exists" errors?

How Prism chooses which ViewModel to attach to a View?

How View Discovery works internally?

Prism module loading sequence.

4️ Advanced XAML & Control Architecture
Study:

CustomControls vs UserControls

ControlTemplates & default styles (Themes/Generic.xaml)

Template selectors

Style scoping & resource dictionaries

Merged dictionaries (large app structuring)

Converters & MultiBindings

Behaviors (Microsoft.Xaml.Behaviors)

Attached behaviors for reusable logic

Senior-level questions:

When to use Attached Properties vs Behaviors?

Difference between DataTemplate and ControlTemplate?

How to create a reusable control library?

Why binding doesn’t update on NotifyPropertyChanged (common pitfalls)?

5️ UI Threading, Async, and Dispatcher
Master:

Dispatcher queue

Invoke vs BeginInvoke

SynchronizationContext

ConfigureAwait(false) pitfalls in WPF

Updating UI from background threads

Async operations in ViewModels

Throttling / debouncing UI updates

Senior-level questions:

How to prevent UI freeze when many updates occur?

How to marshal back to UI thread safely?

Why async void commands are dangerous?

6️ Performance Optimization (Senior Must-Know)
Study:

Reduce layout & measure passes

VirtualizingStackPanel & UI virtualization

Recycling containers

Using DeferRefresh with CollectionView

Freezing brushes & drawings

Avoid heavy bindings in items controls

Template caching

Profiling tools (WPF Perf, Visual Studio Diagnostic Tools)

Senior-level questions:

How to optimize a ListView with 10,000 rows?

Why virtualization sometimes turns off automatically?

When should you use x:Shared="False"?

7️ Interop & Platform Integration
Learn:

WebView2 integration

Win32 interop

Host WinForms in WPF (and vice versa)

Working with dialogs

Command-line args, shutdown politics

Clipboard, drag & drop

Unsafe/low-level operations (HwndHost, DirectX/WPF interop)

Senior-level questions:

How to host a browser component and interact via JS?

Why WPF DPI scaling breaks pixel-perfect layouts?

8️ Testability
Study:

MVVM unit testing

Mocking services

Weak event patterns

How to test dialogs and navigation

Senior-level questions:

How to write unit tests for ViewModels that depend on navigation?

How do you test converters/behaviors?

9️ Memory Management & Diagnostics
Deep topics:

Memory leaks (most common WPF issue)

Event handler leaks

Static references to DependencyObjects

Binding lifetime issues

Weak Event Pattern

Senior-level questions:

What causes the most common memory leaks in WPF apps?

How to debug a leak caused by bindings?

Why large apps slow down after opening/closing many views?

10 Plan Your Study Schedule (2–3 Weeks)
Week 1 — Fundamentals refresh

DependencyProperties, templates, styles, data binding

MVVM patterns

Prism basics

Week 2 — Enterprise features

Prism navigation, region manager, DI setup

Threading, Dispatcher

Performance & virtualization

Week 3 — Senior topics

Memory leaks, diagnostics

Custom controls, behaviors

Interop & async

Build a small demo project with navigation + Prism + custom controls