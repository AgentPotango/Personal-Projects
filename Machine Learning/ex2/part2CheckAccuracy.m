%Max 100 x 3 examples from maindata
%testinglabels has to be the same amount so make testing arrays with
%100 from benchmarkdata as well.
function part2CheckAccuracy(trainingData, testinglbl, ...
                            kValue, predictionMatrix)

showdata(trainingData, testinglbl, predictionMatrix(kValue,:));

