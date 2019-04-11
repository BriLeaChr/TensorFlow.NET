﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TensorFlowNET.Examples;
using TensorFlowNET.Examples.CnnTextClassification;

namespace TensorFlowNET.UnitTest.ExamplesTests
{
    [TestClass]
    public class ExamplesTest
    {
        [TestMethod]
        public void BasicOperations()
        {
            new BasicOperations() { Enabled = true }.Run();
        }

        [TestMethod]
        public void HelloWorld()
        {
            new HelloWorld() { Enabled = true }.Run();
        }

        [TestMethod]
        public void ImageRecognition()
        {
            new HelloWorld() { Enabled = true }.Run();
        }

        [Ignore]
        [TestMethod]
        public void InceptionArchGoogLeNet()
        {
            new InceptionArchGoogLeNet() { Enabled = true }.Run();
        }

        [Ignore]
        [TestMethod]
        public void KMeansClustering()
        {
            new KMeansClustering() { Enabled = true }.Run();
        }

        [TestMethod]
        public void LinearRegression()
        {
            new LinearRegression() { Enabled = true }.Run();
        }

        [TestMethod]
        public void LogisticRegression()
        {
            new LogisticRegression() { Enabled = true, TrainingEpochs=10, TrainSize = 500, ValidationSize = 100, TestSize = 100 }.Run();
        }

        [Ignore]
        [TestMethod]
        public void MetaGraph()
        {
            new MetaGraph() { Enabled = true }.Run();
        }

        [Ignore]
        [TestMethod]
        public void NaiveBayesClassifier()
        {
            new NaiveBayesClassifier() { Enabled = true }.Run();
        }

        [Ignore]
        [TestMethod]
        public void NamedEntityRecognition()
        {
            new NamedEntityRecognition() { Enabled = true }.Run();
        }

        [TestMethod]
        public void NearestNeighbor()
        {
            new NearestNeighbor() { Enabled = true, TrainSize = 500, ValidationSize = 100, TestSize = 100 }.Run();
        }

        [Ignore]
        [TestMethod]
        public void TextClassificationTrain()
        {
            new TextClassificationTrain() { Enabled = true, DataLimit=100 }.Run();
        }

        [Ignore]
        [TestMethod]
        public void TextClassificationWithMovieReviews()
        {
            new TextClassificationWithMovieReviews() { Enabled = true }.Run();
        }
        
    }
}
