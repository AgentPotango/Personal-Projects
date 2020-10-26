function [predictLabel, accuracy, testingDataProb] = NBCTest(mean,std, priorProb, testAttributeSet, validLabel)
format long
%uniqueValues = unique(testAttributeSet);
uniqueLabels = unique(validLabel);
noOfTestingData = size(testAttributeSet,1);
noOfTestingAttributes = size(testAttributeSet,2);
%noOfTestingValues = size(unique(testAttributeSet),1);
noOfConditions = size(unique(validLabel),1);
testingDataProb = ones(noOfTestingData,noOfConditions);
predictLabel = zeros(noOfTestingData,1);

for i = 1:noOfTestingData
    for j = 1:noOfConditions
        testingDataProb(i,j) = testingDataProb(i,j) * priorProb(1,j);
    end
end

for i = 1:noOfTestingData
    for j = 1:noOfConditions
        for k = 1:noOfTestingAttributes
            testingDataProb(i,j) = testingDataProb(i,j) * normpdf(testAttributeSet(i,k),mean(j,k),std(j,k));
        end
    end
end
            
max = zeros(noOfTestingData);
accuratePrediction = 0;
for i = 1:noOfTestingData
    for j = 1:noOfConditions
        if (testingDataProb(i,j) > max(i))
            max(i) = testingDataProb(i,j);
            predictLabel(i,1) = uniqueLabels(j,1);
        end
    end
end

for i = 1:noOfTestingData
    if (predictLabel(i,1) == validLabel(i,1))
        accuratePrediction = accuratePrediction + 1;
    end
end

accuracy = accuratePrediction/noOfTestingData; 
        

            