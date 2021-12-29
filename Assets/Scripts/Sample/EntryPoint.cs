using System.Collections;
using System.Collections.Generic;
using Sample;
using UnityEngine;
using VContainer.Unity;

public class EntryPoint : IInitializable
{
    private IBar _bar;

    public EntryPoint(IBar ibar)
    {
        Debug.Log("Init EntryPoint");

        _bar = ibar;
    }

    public void Initialize()
    {
        Debug.Log(_bar.GetName());
    }
}