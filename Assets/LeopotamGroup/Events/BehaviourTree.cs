﻿//-------------------------------------------------------
// LeopotamGroupLibrary for unity3d
// Copyright (c) 2012-2016 Leopotam <leopotam@gmail.com>
//-------------------------------------------------------

namespace LeopotamGroup.Events {
    /// <summary>
    /// Behaviour tree.
    /// </summary>
    public sealed class BehaviourTree<T> where T: class, new() {
        readonly BehaviourTreeSequence _root;

        readonly T _store;

        /// <summary>
        /// Initialize new instance BehaviourTree class with custom store logic.
        /// If logic instance  will be null - new store logic instance will be created.
        /// </summary>
        /// <param name="store">Store logic instance.</param>
        public BehaviourTree (T store = null) {
            _root = new BehaviourTreeSequence ();
            if (store == null) {
                store = new T ();
            }
            _store = store;
        }

        /// <summary>
        /// Gets root node of graph.
        /// </summary>
        /// <returns>The root node.</returns>
        public BehaviourTreeContainerBase GetRootNode () {
            return _root;
        }

        /// <summary>
        /// Gets store logic instance.
        /// </summary>
        /// <returns>The store.</returns>
        public T GetStore () {
            return _store;
        }

        /// <summary>
        /// Process logic of behaviour tree graph.
        /// </summary>
        public BehaviourTreeResult Process () {
            return _root.Process ();
        }
    }
}