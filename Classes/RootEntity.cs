﻿using System.Collections.Generic;
using OpenTK;

namespace PSXPrev.Classes
{
    public class RootEntity : EntityBase
    {
        private readonly List<ModelEntity> _groupedModels = new List<ModelEntity>();

        public override void ComputeBounds()
        {
            base.ComputeBounds();
            var bounds = new BoundingBox();
            foreach (var entity in ChildEntities)
            {
                bounds.AddPoints(entity.Bounds3D.Corners);
            }
            Bounds3D = bounds;
        }

        public List<ModelEntity> GetModelsWithTMDID(uint id)
        {
            _groupedModels.Clear();
            foreach (var entityBase in ChildEntities)
            {
                var model = (ModelEntity) entityBase;
                if (model.TMDID == id)
                {
                    _groupedModels.Add(model);
                }
            }
            return _groupedModels;
        }

        public void ResetAnimationData()
        {
            foreach (ModelEntity modelEntity in ChildEntities)
            {
                modelEntity.Interpolator = 0;
                modelEntity.InitialVertices = null;
                modelEntity.FinalVertices = null;
                modelEntity.InitialNormals = null;
                modelEntity.FinalNormals = null;
                modelEntity.TempMatrix = Matrix4.Identity;
            }
        }
    }
}