using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterProperty : MonoBehaviour
{
    Animator _anim = null;
    protected Animator myAnim
    {
        get
        {
            if (_anim == null)
            {
                _anim = GetComponent<Animator>();
                if (_anim == null)
                {
                    _anim = GetComponentInChildren<Animator>();
                }
            }
            return _anim;
        }
    }

    SpriteRenderer _renderer = null;
    protected SpriteRenderer myRenderer
    {
        get
        {
            if (_renderer == null)
            {
                _renderer = GetComponent<SpriteRenderer>();
                if (_renderer == null)
                {
                    _renderer = GetComponentInChildren<SpriteRenderer>();
                }
            }
            return _renderer;
        }
    }

    Rigidbody2D _rigid = null;
    protected Rigidbody2D myRigid
    {
        get
        {
            if (_rigid == null)
            {
                _rigid = GetComponent<Rigidbody2D>();
                if (_rigid == null)
                {
                    _rigid = GetComponentInChildren<Rigidbody2D>();
                }
            }
            return _rigid;
        }
    }

    Collider2D _collider = null;
    protected Collider2D myCollider
    {
        get
        {
            if (_collider == null)
            {
                _collider = GetComponent<Collider2D>();
                if (_collider == null)
                {
                    _collider = GetComponentInChildren<Collider2D>();
                }
            }
            return _collider;
        }
    }
}

