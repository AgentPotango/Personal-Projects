%[accuracy, predictionMatrix] = part2B(trainingData, testingData,
%                                      trainingLabels, testingLabels, 
%                                      featureNo)
%
%accuracy - number of training data by 1 matrix (Nx1 Matrix)
%           i.e.  300 rows in training data ---> accuracy = 300x1 Matrix
%
%predicitionMatrix - numberOfTrainingData x numberOfTestData Matrix
%                     (N x M Matrix)
%Holds the predictions for each value of N for each M example of Test Data
%i.e predictionMatrix(115,:) would be M predictions for K = 115
%
%trainingData - should be an NxM matrix consisting of N examples of
%training data
%
%testingData - should be an NxM matrix consisting of N examples of testing
%data
%
%trainingLabels - should be a Nx1 column vector, with class labels.
%
%testingLabels - should be a Nx1 column vector, with class labels.
%
%featureNo - should be a number in the range 1-7.

function [accuracy, predictionMatrix] = part2B(trainingData,testingData,...
                                               trainingLabels, ...
                                               testingLabels, featureNo)

feature = extractmyfeatures(reshape(testingData(1,:),16,16),featureNo);
noOfFeatures = size(feature,2);

noOfTrainingData = size(trainingData,1);
noOfTestingData = size(testingData,1);


trainingFeatures = zeros(noOfTrainingData,noOfFeatures);
testingFeatures = zeros(noOfTestingData,noOfFeatures);

for i=1:noOfTrainingData 
    trainingFeatures(i,:) = extractmyfeatures(reshape(...
                            trainingData(i,:),16,16),featureNo);
end

for i=1:noOfTestingData
    testingFeatures(i,:) = extractmyfeatures(reshape(...
                            testingData(i,:),16,16),featureNo);
end                            

x = 1:1:noOfTrainingData;
accuracy = zeros(noOfTrainingData,1);
predictionMatrix = zeros(noOfTrainingData,noOfTestingData);
for i=1:noOfTrainingData
    for j=1:noOfTestingData
        prediction = knearest(i,testingFeatures(j,:),trainingFeatures,...
                              trainingLabels);
        predictionMatrix(i,j) = prediction;
        if (prediction == testingLabels(j, :))
          accuracy(i,1) = accuracy(i,1) + 1;
       end
    end
end
accuracy =accuracy(x,:)./noOfTestingData;
figure();
y = accuracy;
plot(x,y);
xlabel('Values for K');
ylabel(['Accuracy for ' num2str(noOfTestingData) ' Testing Examples'])
title(['Accuracy of ' num2str(noOfFeatures) ' Features with K-nearest' ...
       ' w.r.t. K']);

  
