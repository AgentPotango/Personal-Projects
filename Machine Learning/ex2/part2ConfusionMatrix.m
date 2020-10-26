function part2ConfusionMatrix(trueLabels, predictionMatrix, kValue)

predictions = predictionMatrix(kValue,:);

[confusionMatrix, labels] = confusionmat(trueLabels, predictions)

disp('Incase the confusionmat function doesnt work: run part2ConfM ');


