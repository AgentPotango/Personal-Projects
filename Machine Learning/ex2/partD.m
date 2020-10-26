function partD(valuesArray, trainingData, noOfTrainData, noOfGraphs)

noOfValues = size(valuesArray,1);
noOfTrainExamples = (noOfTrainData * noOfValues)/2;
[train,trainlbl] = partA(trainingData, noOfTrainData, valuesArray);
graphsAccuracy = zeros(noOfTrainExamples,noOfGraphs);


for i = 1:noOfGraphs
    [accuracy] = partC(train,trainlbl);
    graphsAccuracy(:,i) = accuracy;
end
meanAccuracy = mean(graphsAccuracy,2);

figure();
x = 1:1:noOfTrainExamples;
e = std(graphsAccuracy,0,2);
y = meanAccuracy;
%e = std(y)*ones(size(x));
errorbar(x,y,e);
xlabel('Values for K');
ylabel('Average Accuracy');
txt=char(['Mean Testdata Accuracy (for ' num2str(noOfGraphs) ...
          ' Graphs) '], ... 
          'with respect to K (With Standard Deviation and Error Bars)');
title(txt);





%accuracyPartC = partC;
%accuracyPartD = partC(trainingdata, labels);

%y = (((accuracyPartC + accuracyPartD)./ 2)./300);
%x = 1:1:150;
%hold off;
%e = std(y)*ones(size(x));

%figure();
%errorbar(x,y,e);
%txt=char('Test Data Accuracy with respect to K of Two Graphs', ...
 %        '(With Average and Standard Deviation)');
%title(txt);

