using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;
using UnityEngine;

[CreateAssetMenu]
public class IdentifiedObject : ScriptableObject, ICloneable
{
    #region 1-3-1
    [SerializeField]
    private Category[] categories;
    #endregion

    #region 1-1
    [SerializeField]
    private Sprite icon;
    [SerializeField]
    private int id = -1;
    [SerializeField]
    private string codeName;
    [SerializeField]
    private string displayName;
    [SerializeField]
    private string description;

    public Sprite Icon => icon;
    public int ID => id;
    public string CodeName => codeName;
    public string DisplayName => displayName;
    public virtual string Description => description;
    #endregion

    #region 1-2
    public virtual object Clone() => Instantiate(this);
    #endregion

    #region 1-3-2
    public bool HasCategory(Category category)
        => categories.Any(x => x.ID == category.ID);

    public bool HasCategory(string category)
        => categories.Any(x => x == category);
    #endregion
}
