﻿NotInheritable Class App
    Inherits Application

    Public Sub New()
        InitializeComponent()
    End Sub

    Protected Overrides Sub OnLaunched(e As LaunchActivatedEventArgs)
        Dim rootFrame = TryCast(Window.Current.Content, Frame)
        If rootFrame Is Nothing Then
            rootFrame = New Frame()
            If e.PreviousExecutionState = ApplicationExecutionState.Terminated Then
                ' TODO: Load state from previously suspended application
            End If
            Window.Current.Content = rootFrame
        End If
        If rootFrame.Content Is Nothing Then rootFrame.Navigate(GetType(MainPage), e.Arguments)
        Window.Current.Activate()
    End Sub

    Private Sub OnSuspending(sender As Object, e As SuspendingEventArgs) Handles Me.Suspending
        Dim deferral As SuspendingDeferral = e.SuspendingOperation.GetDeferral()
        ' TODO: Save application state and stop any background activity
        deferral.Complete()
    End Sub

End Class
