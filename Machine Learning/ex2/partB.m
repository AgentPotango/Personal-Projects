%classifies the data for differing values of k
%plots the accuracy with respect to k graph

%trainingdata = 200x256 matrix
%labels = 200x1 matrix

function [accuracy] = partB(trainingdata,testingdata, trainlabels, ...
                            testlabels)
noOfTrainingData = size(trainingdata,1); 
noOfTestingData = size(testingdata,1);
x=1:1:noOfTrainingData;
accuracy = zeros(noOfTrainingData,1);
for i=1:noOfTrainingData
    for j=1:noOfTestingData
       prediction = knearest(i,testingdata(j, :), trainingdata, trainlabels);
       if (prediction == testlabels(j, :))
           accuracy(i,1) = accuracy(i,1) + 1;
       end
    end            
end
accuracy = accuracy(x,:)./noOfTrainingData;
y=accuracy;
figure();
plot(x,y);
xlabel('Values for K');
ylabel(['Accuracy for ' num2str(noOfTestingData) ' Testing Examples'])
title('Accuracy of K-nearest with respect to K');

