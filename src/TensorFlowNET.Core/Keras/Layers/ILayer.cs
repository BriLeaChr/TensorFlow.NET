﻿using System.Collections.Generic;
using Tensorflow.Keras.Engine;

namespace Tensorflow.Keras
{
    public interface ILayer
    {
        string Name { get; }
        bool Trainable { get; }
        List<ILayer> Layers { get; }
        List<INode> InboundNodes { get; }
        List<INode> OutboundNodes { get; }
        Tensors Apply(Tensors inputs, Tensor state = null, bool is_training = false);
        List<IVariableV1> trainable_variables { get; }
        TensorShape output_shape { get; }
        int count_params();
    }
}
