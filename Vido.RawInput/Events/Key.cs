﻿namespace Vido.RawInput.Events
{
  using System;
  using Vido.RawInput.Interfaces;

  public delegate void KeyEventHandler(IKeyboard s, KeyEventArgs e);

  public class KeyEventArgs : EventArgs
  {
    private int keyValue;

    public KeyEventArgs(int keyCode)
    {
      this.keyValue = keyCode;
    }
    public int KeyValue
    {
      get { return (keyValue); }
    }
  }
}
