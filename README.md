# WpfDeferredResourceLookupRepro

This reproduces the issue described in [this](https://github.com/dotnet/wpf/issues/4468) WPF bug report.

See the comments in **Styles\Styles.xaml** for details about how this project reproduces the conditions
that cause this WPF performance bottleneck.

When running the application, the right hand side of the view contains elements that control and diagnose
the problem. The left hand side contains the elements that cause deferred resource references to be accumulated.

The **Count:** field uses reflection to display the total number of elements in the internal
`_deferredResourceReferences` field of every resource dictionary merged into the application’s resources.
